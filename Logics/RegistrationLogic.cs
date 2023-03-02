using LibraryProject.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryProject.DAL;
using LibraryProject.DataModels;

namespace LibraryProject.Logics
{
    internal class RegistrationLogic
    {
        Registration registration;
        TextBox usernameTextBox;
        TextBox emailTextBox;
        TextBox passwordTextBox;
        TextBox confirmTextBox;
        Button singInButton;
        Button signUpButton;

        public RegistrationLogic() { }
        public void getForm(Registration form, TextBox username, TextBox email, TextBox passowrd, TextBox confirm, Button singIn, Button signUp)
        {
            this.registration = form; 
            this.usernameTextBox = username;
            this.emailTextBox = email;
            this.passwordTextBox = passowrd;
            this.confirmTextBox= confirm;
            this.singInButton= singIn;
            this.signUpButton= signUp;
        }


        internal bool checkIfDataIsCorrect()
        {
            if (!string.IsNullOrWhiteSpace(usernameTextBox.Text) && emailTextBox.Text.Contains('@'))
                return true;
            MessageBox.Show("given data incorrect");
            return false;


        }

        internal bool checkPassword()
        {
            if(passwordTextBox.Text == confirmTextBox.Text)
            {
                return true;
            }
            MessageBox.Show("passwords don't match");
            return false;
        }

        internal void checkIfSignInEnabled()
        {
            if(usernameTextBox.Text != "" && emailTextBox.Text != "" && passwordTextBox.Text != "") 
                this.singInButton.Enabled = true;
            else
                this.singInButton.Enabled = false;
        }

        internal void checkIfSignUpEnabled()
        {
            if(this.singInButton.Enabled && confirmTextBox.Text != "") 
                this.signUpButton.Enabled = true;
            else
                this.signUpButton.Enabled = false;        
        }

        internal void addToDB()
        {
            using(var db = new LibraryContext())
            {
                db.Users.Add(new User()
                {
                    Username = usernameTextBox.Text,
                    Email = emailTextBox.Text,
                    Password = passwordTextBox.Text,
                    RoleId = 2
                });
                db.SaveChanges();
                MessageBox.Show("succesfully registered");
            }
        }

        internal bool checkIfExists()
        {
            using(var db = new LibraryContext())
            {
                if (db.Users.Any(u => (u.Username == usernameTextBox.Text) || (u.Email == emailTextBox.Text)))
                {
                    MessageBox.Show("user with given credits already exists");
                    return true;
                }
            }
            return false;
        }

        internal bool checkIfLoginDataCorrect()
        {
            using(var db = new LibraryContext())
            {
                if (db.Users.Any(u => u.Username == usernameTextBox.Text && u.Email == emailTextBox.Text && u.Password == passwordTextBox.Text))
                    return true;
            }
            return false;
        }

        internal void openHomeForm()
        {
            this.registration.Hide();
            Home home = new Home();
            home.setParams(this.usernameTextBox.Text);
            home.ShowDialog();
            this.registration.Close();
        }
    }
}
