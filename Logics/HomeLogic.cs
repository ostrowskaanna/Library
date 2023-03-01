using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryProject.DAL;
using LibraryProject.DataModels;
using LibraryProject.Forms;

namespace LibraryProject.Logics
{
    internal class HomeLogic
    {
        Home home;
        MenuStrip menu;
        public HomeLogic() { }

        public void getForm(Home home, MenuStrip menu)
        {
            this.home = home;
            this.menu = menu;
        }

        public int getId(string username)
        {
            using(var db = new LibraryContext())
            {
                var id = (from u in db.Users
                          where u.Username == username
                          select u.Id).First();
                return id;
            }
        }

        public Role getRole(int id)
        {
            using(var db = new LibraryContext())
            {
                var perms = (from r in db.Roles
                             join u in db.Users
                             on r.Id equals u.RoleId
                             where u.Id == id
                             select r).FirstOrDefault();
                return perms;
            }
        }

        public int getNumberOfBooks(int id)
        {
            using(var db = new LibraryContext())
            {
                var number = (from ub in db.UsersBooks
                              where ub.UserId == id
                              select ub).Count();
                return number;              
            };
        }

        public void closePage(Form form)
        {
            this.home.Hide();
            form.ShowDialog();
            this.home.Hide();
        }
    }
}
