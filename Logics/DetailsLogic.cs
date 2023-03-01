using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryProject.Forms;
using LibraryProject.DAL;

namespace LibraryProject.Logics
{
    internal class DetailsLogic
    {
        Details details;
        int id;

        public DetailsLogic() { }

        public void getForm(Details details)
        {
            this.details = details;
        }

        public void getData(int id)
        {
            this.id = id;
            using(var db = new LibraryContext())
            {
                this.details.usernameLabel.Text = "username: " +  db.Users.FirstOrDefault(u => u.Id == this.id).Username;
                this.details.emailLabel.Text = "email: " + db.Users.FirstOrDefault(u => u.Id == this.id).Email;
            }
        }

        public void openChangeForm(string name, int id)
        {
            Change change = new Change();
            change.getData(name, id);
            change.ShowDialog();
        }
    }
}
