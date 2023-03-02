using LibraryProject.DataModels;
using LibraryProject.Logics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.Forms
{
    public partial class Home : Form
    {
        HomeLogic logic = new HomeLogic();

        //custom controls
        List<UserControl> customControls = new List<UserControl>();
        Details details = new Details();
        Welcome welcome = new Welcome();
        BooksView booksView = new BooksView();
        NewBookForm newBookForm = new NewBookForm();
        UsersView usersView = new UsersView();
        NewUserForm newUserForm = new NewUserForm();

        string username; //username of logged in user
        int id; //id of logged in user
        Role role; //role of logged in user 
        public Home()
        {
            InitializeComponent();
            this.logic.getForm(this, this.menu);
        }

        public void setParams(string username)
        {
            this.getUsername(username);
            this.checkPermissons();
            this.getComponents();
        }

        public void getUsername(string username)
        {
            this.username = username;
            this.id = this.logic.getId(this.username);   
        }

        public void getComponents()
        {
            this.welcome.getData(this.id);
            this.Controls.Add(this.welcome);
            this.customControls.Add(this.welcome);

            this.details.getData(this.id);
            this.Controls.Add(this.details);
            this.customControls.Add(this.details);

            this.booksView.getData(this.id, this.role);
            this.Controls.Add(this.booksView);
            this.customControls.Add(this.booksView);

            this.Controls.Add(this.newBookForm);
            this.customControls.Add(this.newBookForm);

            this.Controls.Add(this.usersView);
            this.customControls.Add(this.usersView);

            this.Controls.Add(this.newUserForm);
            this.customControls.Add(this.newUserForm);
        }
          
        public void checkPermissons()
        {
            this.role = this.logic.getRole(this.id);
            this.seeUserDetailsToolStripMenuItem.Visible = this.role.SeeUserDetails;
            this.seeYourBooksToolStripMenuItem.Visible = this.role.SeeYourBooks;
            this.borrowBookToolStripMenuItem.Visible = this.role.BorrowBook;
            this.seeAvailableBooksToolStripMenuItem.Visible = this.role.SeeAllBooks;
            this.addNewBookToolStripMenuItem.Visible = this.role.AddBook;
            this.removeBookToolStripMenuItem.Visible = this.role.RemoveBook;
            this.seeAllUsersToolStripMenuItem.Visible = this.role.SeeAllUsers;
            this.addNewUserToolStripMenuItem.Visible = this.role.AddUser;
            this.removeUserToolStripMenuItem.Visible = this.role.RemoveUser;
            this.seeAllRolesToolStripMenuItem.Visible = this.role.SeeAllRoles;
            this.addNewRoleToolStripMenuItem.Visible = this.role.AddRole;
            this.removeRoleToolStripMenuItem.Visible = this.role.RemoveRole;
        }

        //changing view
        private void logOut(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            logic.closePage(registration);
        }

        private void seeUserDetails(object sender, EventArgs e)
        {
            this.hideAllCustomControls();
            details.getData(this.id);
            this.details.Visible = true;
        }

        private void seeYourBooks(object sender, EventArgs e)
        {
            this.hideAllCustomControls();
            booksView.loadData(false, true);
            this.booksView.Visible = true;
        }

        private void borrowBook(object sender, EventArgs e)
        {
            this.hideAllCustomControls();
            booksView.loadData(true, true);
            this.booksView.Visible = true;
        }

        private void seeAllBooks(object sender, EventArgs e)
        {
            this.hideAllCustomControls();
            booksView.loadData(true, false);
            this.booksView.Visible = true;
        }

        private void addNewBook(object sender, EventArgs e)
        {
            this.hideAllCustomControls();
            this.newBookForm.Visible = true;
        }

        private void removeBook(object sender, EventArgs e)
        {
            this.hideAllCustomControls();
            booksView.loadData(true, true);
            this.booksView.Visible = true;
        }

        private void seeAllUsers(object sender, EventArgs e)
        {
            this.hideAllCustomControls();
            usersView.loadData(false);
            this.usersView.Visible = true;
        }

        private void addNewUser(object sender, EventArgs e)
        {
            this.hideAllCustomControls();
            this.newUserForm.Visible = true;
        }

        private void removeUser(object sender, EventArgs e)
        {
            this.hideAllCustomControls();
            usersView.loadData(true);
            this.usersView.Visible = true;
        }

        private void seeAllRoles(object sender, EventArgs e)
        {

        }

        private void addNewRole(object sender, EventArgs e)
        {

        }

        private void removeRole(object sender, EventArgs e)
        {

        }

        public void hideAllCustomControls()
        {
            foreach(var control in this.customControls)
            {
                control.Visible = false;
            }
        }
    }
}
