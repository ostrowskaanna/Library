using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryProject.Forms;
using LibraryProject.DAL;
using System.Windows.Forms.VisualStyles;
using LibraryProject.DataModels;

namespace LibraryProject.Logics
{
    internal class BooksViewLogic
    {
        BooksView booksView;
        DataGridView dataGridView1;
        BindingSource bindingSource;
        Label infoLabel;
        Button confirmButton;

        int bookId;

        bool allowCellClick;
        bool showAllBooks;
        string buttonAction;

        int id;
        Role role;

        public void getForm(BooksView booksView, DataGridView dataGridView1, Label infoLabel, Button confirmButton)
        {
            this.booksView = booksView;
            this.dataGridView1 = dataGridView1;
            this.infoLabel = infoLabel;
            this.confirmButton = confirmButton;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Columns[0].Visible = false;
        }

        public void loadData(bool all, bool choose, int id, Role role)
        {
            this.id = id;
            this.role = role;
            this.allowCellClick = choose;
            this.showAllBooks = all;
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LibraryDatabase;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            var query = "";

            //display books that can be borrowed
            if (all && choose && role.Id == 2)
            {
                query = "SELECT * FROM Books WHERE Quantity > 0";
                this.dataGridView1.Columns[4].Visible = true;
                this.dataGridView1.DefaultCellStyle.SelectionBackColor = this.dataGridView1.DefaultCellStyle.ForeColor;
                this.dataGridView1.DefaultCellStyle.SelectionForeColor = this.dataGridView1.DefaultCellStyle.BackColor;
                this.infoLabel.Text = "If you want to borrow a book select it and click the button: ";
                this.confirmButton.Visible = true;
                this.buttonAction = "borrow";
                
            }
            //display all books
            else if (all && !choose)
            {
                query = "SELECT Id, Title, Author, Description FROM Books";
                this.dataGridView1.Columns[4].Visible = false;
                this.dataGridView1.DefaultCellStyle.SelectionBackColor = this.dataGridView1.DefaultCellStyle.BackColor;
                this.dataGridView1.DefaultCellStyle.SelectionForeColor = this.dataGridView1.DefaultCellStyle.ForeColor;
                this.infoLabel.Text = string.Empty;
                this.confirmButton.Visible = false;
            }
            //display all books with remove option 
            else if(all && choose && role.Id == 1)
            {
                query = "SELECT Id, Title, Author, Description FROM Books";
                this.dataGridView1.Columns[4].Visible = false;
                this.dataGridView1.DefaultCellStyle.SelectionBackColor = this.dataGridView1.DefaultCellStyle.ForeColor;
                this.dataGridView1.DefaultCellStyle.SelectionForeColor = this.dataGridView1.DefaultCellStyle.BackColor;
                this.infoLabel.Text = "If you want to remove a book select it and click the button: ";
                this.confirmButton.Visible = true;
                this.buttonAction = "remove";
            }
            //display user's books
            else
            {
                query = "SELECT DISTINCT b.Id, Title, Author, Description FROM Books b INNER JOIN UserBooks ub ON b.Id = ub.BookId WHERE ub.UserId = " + id;
                this.dataGridView1.Columns[4].Visible = false;
                this.dataGridView1.DefaultCellStyle.SelectionBackColor = this.dataGridView1.DefaultCellStyle.ForeColor;
                this.dataGridView1.DefaultCellStyle.SelectionForeColor = this.dataGridView1.DefaultCellStyle.BackColor;
                this.infoLabel.Text = "If you want to return a book select it and click the button: ";
                this.confirmButton.Visible = true;
                this.buttonAction = "return";
            }
            //retrieve data 
            SqlCommand cmd = new SqlCommand(query, con);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            this.dataGridView1.DataSource = table;
            this.dataGridView1.Rows[0].Selected = false;
            con.Close();
        }


        public void cellClick(DataGridViewCellEventArgs e)
        {
            this.bookId = (int)this.dataGridView1.SelectedCells[0].Value;
        }

        public void confirmBook()
        {
            //user borrows a book
            if (this.buttonAction == "borrow")
            {
                using(var db = new LibraryContext())
                {
                    db.UsersBooks.Add(new DataModels.UserBooks()
                    {
                        BookId = this.bookId,
                        BorrowStart = DateTime.Now,
                        BorrowEnd = DateTime.Now.AddMonths(1),
                        UserId = this.id
                    });
                    db.Books.FirstOrDefault(b => b.Id == this.bookId).Quantity -= 1;
                    db.SaveChanges();
                    MessageBox.Show("book borrowed");
                }
            }
            //user returns a book 
            else if(this.buttonAction == "return")
            {
                using (var db = new LibraryContext())
                {
                    var toRemove = db.UsersBooks.FirstOrDefault(b => (b.BookId == this.bookId && b.UserId == this.id));
                    if (toRemove != null)
                    {
                        db.UsersBooks.Remove(toRemove);
                        db.Books.FirstOrDefault(b => b.Id == this.bookId).Quantity += 1;
                        db.SaveChanges();
                        MessageBox.Show("book returned");
                    }
                    else
                        MessageBox.Show("book id: " + this.bookId + ", user id: " + this.id);
                }
            }
            //admin removes a book 
            else if(this.buttonAction == "remove")
            {
                using (var db = new LibraryContext())
                {
                    var toRemove = db.Books.FirstOrDefault(b => b.Id == this.bookId);
                    if (toRemove != null)
                        db.Books.Remove(toRemove);
                    
                    var usersBooksToRemove = (from ub
                                          in db.UsersBooks
                                              where ub.BookId == this.bookId
                                              select ub).ToList();
                    foreach(var ub in usersBooksToRemove)
                    {
                        db.UsersBooks.Remove(ub);
                    }
                    db.SaveChanges();
                    MessageBox.Show("book removed");
                }
            }
            //refresh data
            this.loadData(this.showAllBooks, this.allowCellClick, this.id, this.role);
            
        }
    }
}
