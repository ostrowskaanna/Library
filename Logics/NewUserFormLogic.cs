using LibraryProject.DAL;
using LibraryProject.DataModels;
using LibraryProject.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.Logics
{
    internal class NewUserFormLogic
    {
        NewUserForm newUserForm;
        Dictionary<int, string> roles;
        public NewUserFormLogic() { }

        public void getForm(NewUserForm form)
        {
            this.newUserForm = form;
            this.roles = new Dictionary<int, string>();
            this.roles.Add(1, "admin");
            this.roles.Add(2, "user");
            this.newUserForm.rolesListBox.DataSource = roles.Values.ToList();
        }

        public void checkIfDataComplete()
        {
            if (this.checkUsername() && this.checkEmail() && this.checkPasswd())
                this.newUserForm.confButton.Enabled = true;
            else
                this.newUserForm.confButton.Enabled = false;
        }
        
        private bool checkUsername()
        {
            if (string.IsNullOrWhiteSpace(this.newUserForm.usernameTextBox.Text))
                return false;
            return true;
        }

        private bool checkEmail()
        {
            if(!this.newUserForm.emailTextBox.Text.Contains('@') || this.newUserForm.emailTextBox.Text.Length < 3)
                return false;
            return true;
        }

        private bool checkPasswd()
        {
            if (this.newUserForm.passwdTextBox.Text.Length == 0)
                return false;
            return true;
        }

        public void addUserToDB()
        {
            using (var db = new LibraryContext())
            {
                var found = db.Users.FirstOrDefault(b => (b.Username == this.newUserForm.usernameTextBox.Text) || (b.Email == this.newUserForm.emailTextBox.Text));
                if (found != null)
                    MessageBox.Show("user with given credits already exists");
                else
                {
                    
                    db.Users.Add(new User()
                    {
                        Username = this.newUserForm.usernameTextBox.Text,
                        Email = this.newUserForm.emailTextBox.Text,
                        Password = this.newUserForm.passwdTextBox.Text,
                        RoleId = this.roles.FirstOrDefault(r => r.Value == this.newUserForm.rolesListBox.SelectedValue.ToString()).Key
                    });
                    db.SaveChanges();
                    MessageBox.Show("user added");
                    this.clearForm();
                }
            }
        }

        public void clearForm()
        {
            this.newUserForm.usernameTextBox.Text = string.Empty;
            this.newUserForm.emailTextBox.Text = string.Empty;
            this.newUserForm.passwdTextBox.Text = string.Empty;
            this.newUserForm.rolesListBox.SelectedIndex = 0;
        }
    }
}
