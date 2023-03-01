using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryProject.Forms;
using LibraryProject.DAL;
using LibraryProject.DataModels;
using System.Windows.Forms;

namespace LibraryProject.Logics
{
    internal class NewBookFormLogic
    {
        NewBookForm newBookForm;
        
        public NewBookFormLogic() { }

        public void getForm(NewBookForm form)
        {
            this.newBookForm = form;
        }

        public void checkIfDataComplete()
        {
            if (this.newBookForm.titleTextBox.Text.Length > 0
                && this.newBookForm.authorTextBox.Text.Length > 0
                && this.newBookForm.quantityNumeric.Value > 0
                && this.newBookForm.descTextBox.Text.Length > 0)
            {
                this.newBookForm.confButton.Enabled = true;
            }
            else
                this.newBookForm.confButton.Enabled = false;
        }

        public void addBookToDB()
        {
            using (var db = new LibraryContext())
            {
                var found = db.Books.FirstOrDefault(b => b.Title == this.newBookForm.titleTextBox.Text && b.Author == this.newBookForm.authorTextBox.Text);
                if (found != null)
                    MessageBox.Show("book with given title and author already exists in library");
                else
                { 
                    db.Books.Add(new Book()
                    {
                        Title = this.newBookForm.titleTextBox.Text,
                        Author = this.newBookForm.authorTextBox.Text,
                        Description = this.newBookForm.descTextBox.Text,
                        Quantity = (int)this.newBookForm.quantityNumeric.Value
                    });
                    db.SaveChanges();
                    MessageBox.Show("book added");
                    this.clearForm();
                }
            }
        }

        public void clearForm()
        {
            this.newBookForm.titleTextBox.Text = string.Empty;
            this.newBookForm.authorTextBox.Text = string.Empty;
            this.newBookForm.quantityNumeric.Value = 0;
            this.newBookForm.descTextBox.Text = string.Empty;
        }
    }
}
