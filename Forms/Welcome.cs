using LibraryProject.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.Forms
{
    public partial class Welcome : UserControl
    {
        int id;
        public Welcome()
        {
            InitializeComponent();
        }
        public void getData(int id)
        {
            this.id = id;
            using(var db = new LibraryContext())
            {
                this.welcomeLabel.Text += db.Users.FirstOrDefault(u => u.Id == id).Username;
                if(db.Users.FirstOrDefault(u => u.Id == id).RoleId == 2)
                {
                    this.booksLabel.Text += db.UsersBooks.Count(ub => ub.UserId == id).ToString();
                    this.booksLabel.Text += " books borrowed";
                }
                else
                {
                    this.booksLabel.Visible = false;
                }
            }
        }
    }
}
