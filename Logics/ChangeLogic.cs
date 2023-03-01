using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryProject.DAL;
using LibraryProject.Forms;

namespace LibraryProject.Logics
{
    internal class ChangeLogic
    {
        Change change;
        int userId;
        string dataToChange;

        public void getForm(Change change)
        {
            this.change = change;
        }

        public void getId(int id)
        {
            this.userId = id;
        }

        public void checkIfClickEnable(TextBox oldPassword, TextBox newData, Button confirm, string name)
        {
            this.dataToChange = name;

            //password change
            if(this.dataToChange == "changePasswordButton")
            {
                if(oldPassword.Text.Length > 0 && newData.Text.Length > 0)
                    confirm.Enabled = true;
                else 
                    confirm.Enabled = false;
            }
            //username or email change
            else
            {
                if(newData.Text.Length > 0)
                    confirm.Enabled = true;
                else 
                    confirm.Enabled = false;
            }
        }

        public void changeDataInDB(TextBox oldPassword, TextBox newData)
        {
            if(this.dataToChange == "changePasswordButton")
            {
                using (var db = new LibraryContext())
                {
                    if (db.Users.FirstOrDefault(u => u.Id == this.userId).Password != oldPassword.Text)
                        MessageBox.Show("wrong password");
                    else
                    {
                        db.Users.FirstOrDefault(u => u.Id == this.userId).Password = newData.Text;
                        db.SaveChanges();
                        MessageBox.Show("password changed successfully");
                        this.closeForm();

                    }
                }
            }
            else if(this.dataToChange == "changeUsernameButton")
            {
                using (var db = new LibraryContext())
                {
                    if (db.Users.Any(u => u.Username == newData.Text))
                        MessageBox.Show("given username is taken");
                    else
                    {
                        db.Users.FirstOrDefault(u => u.Id == this.userId).Username = newData.Text;
                        db.SaveChanges();
                        MessageBox.Show("username chagned successfully");
                        this.closeForm();
                    }
                }
            }
            else if (this.dataToChange == "changeEmailButton")
            {
                using (var db = new LibraryContext())
                {
                    if (db.Users.Any(u => u.Email == newData.Text))
                        MessageBox.Show("given email is taken");
                    else
                    {
                        db.Users.FirstOrDefault(u => u.Id == this.userId).Email = newData.Text;
                        db.SaveChanges();
                        MessageBox.Show("email changed successfully");
                        this.closeForm();
                    }
                }
            }
        }

        public void closeForm()
        {
            this.change.Close();
        }

    }
}
