using LibraryProject.DAL;
using LibraryProject.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.Logics
{
    internal class UsersViewLogic
    {
        UsersView usersView;

        int userId;
        public UsersViewLogic() { }

        public void getForm(UsersView usersView)
        {
            this.usersView = usersView;
            this.usersView.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void setForm(bool action)
        {
            if (!action)
            {
                this.usersView.infoLabel.Visible = false;
                this.usersView.confButton.Visible = false;
                this.usersView.dataGridView1.Enabled = false;
            }
            else if(action)
            {
                this.usersView.infoLabel.Visible = true;
                this.usersView.confButton.Visible = true;
                this.usersView.dataGridView1.Enabled = true;
            }

        }

        public void loadData()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LibraryDatabase;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            var query = "SELECT u.Id, u.Username, u.Email, r.Name as 'Role' FROM Users u INNER JOIN Roles r ON u.RoleId = r.Id";

            //retrieve data 
            SqlCommand cmd = new SqlCommand(query, con);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            this.usersView.dataGridView1.DataSource = table;
            this.usersView.dataGridView1.Rows[0].Selected = false;
            this.usersView.dataGridView1.Columns[0].Visible = false;
            this.usersView.confButton.Enabled = false;
            con.Close();
        }

        public void confirmUser()
        {
            using (var db = new LibraryContext())
            {
                var toRemove = db.Users.FirstOrDefault(u => u.Id == this.userId);
                if (toRemove != null)
                {
                    db.Users.Remove(toRemove);
                    db.SaveChanges();
                    MessageBox.Show("user removed");
                }
            }
            this.loadData();
        }

        public void cellClick(DataGridViewCellEventArgs e)
        {
            if (this.usersView.dataGridView1.SelectedCells.Count > 0)
            {
                this.userId = (int)this.usersView.dataGridView1.SelectedCells[0].Value;
                this.usersView.confButton.Enabled = true;
            }
        }
    }
}
