namespace LibraryProject.Forms
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.userPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeUserDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeYourBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeAvailableBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeAllUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeAllRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userPanelToolStripMenuItem,
            this.booksManagementToolStripMenuItem,
            this.usersManagementToolStripMenuItem,
            this.rolesManagementToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 28);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // userPanelToolStripMenuItem
            // 
            this.userPanelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seeUserDetailsToolStripMenuItem,
            this.seeYourBooksToolStripMenuItem,
            this.borrowBookToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.userPanelToolStripMenuItem.Name = "userPanelToolStripMenuItem";
            this.userPanelToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.userPanelToolStripMenuItem.Text = "User panel";
            // 
            // seeUserDetailsToolStripMenuItem
            // 
            this.seeUserDetailsToolStripMenuItem.Name = "seeUserDetailsToolStripMenuItem";
            this.seeUserDetailsToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.seeUserDetailsToolStripMenuItem.Text = "See user details ";
            this.seeUserDetailsToolStripMenuItem.Click += new System.EventHandler(this.seeUserDetails);
            // 
            // seeYourBooksToolStripMenuItem
            // 
            this.seeYourBooksToolStripMenuItem.Name = "seeYourBooksToolStripMenuItem";
            this.seeYourBooksToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.seeYourBooksToolStripMenuItem.Text = "See your books";
            this.seeYourBooksToolStripMenuItem.Click += new System.EventHandler(this.seeYourBooks);
            // 
            // borrowBookToolStripMenuItem
            // 
            this.borrowBookToolStripMenuItem.Name = "borrowBookToolStripMenuItem";
            this.borrowBookToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.borrowBookToolStripMenuItem.Text = "Borrow book ";
            this.borrowBookToolStripMenuItem.Click += new System.EventHandler(this.borrowBook);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOut);
            // 
            // booksManagementToolStripMenuItem
            // 
            this.booksManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seeAvailableBooksToolStripMenuItem,
            this.addNewBookToolStripMenuItem,
            this.removeBookToolStripMenuItem});
            this.booksManagementToolStripMenuItem.Name = "booksManagementToolStripMenuItem";
            this.booksManagementToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.booksManagementToolStripMenuItem.Text = "Books management";
            // 
            // seeAvailableBooksToolStripMenuItem
            // 
            this.seeAvailableBooksToolStripMenuItem.Name = "seeAvailableBooksToolStripMenuItem";
            this.seeAvailableBooksToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.seeAvailableBooksToolStripMenuItem.Text = "See all books";
            this.seeAvailableBooksToolStripMenuItem.Click += new System.EventHandler(this.seeAllBooks);
            // 
            // addNewBookToolStripMenuItem
            // 
            this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            this.addNewBookToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.addNewBookToolStripMenuItem.Text = "Add new book ";
            this.addNewBookToolStripMenuItem.Click += new System.EventHandler(this.addNewBook);
            // 
            // removeBookToolStripMenuItem
            // 
            this.removeBookToolStripMenuItem.Name = "removeBookToolStripMenuItem";
            this.removeBookToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.removeBookToolStripMenuItem.Text = "Remove book";
            this.removeBookToolStripMenuItem.Click += new System.EventHandler(this.removeBook);
            // 
            // usersManagementToolStripMenuItem
            // 
            this.usersManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seeAllUsersToolStripMenuItem,
            this.addNewUserToolStripMenuItem,
            this.removeUserToolStripMenuItem});
            this.usersManagementToolStripMenuItem.Name = "usersManagementToolStripMenuItem";
            this.usersManagementToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.usersManagementToolStripMenuItem.Text = "Users management";
            // 
            // seeAllUsersToolStripMenuItem
            // 
            this.seeAllUsersToolStripMenuItem.Name = "seeAllUsersToolStripMenuItem";
            this.seeAllUsersToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.seeAllUsersToolStripMenuItem.Text = "See all users";
            this.seeAllUsersToolStripMenuItem.Click += new System.EventHandler(this.seeAllUsers);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.addNewUserToolStripMenuItem.Text = "Add new user";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUser);
            // 
            // removeUserToolStripMenuItem
            // 
            this.removeUserToolStripMenuItem.Name = "removeUserToolStripMenuItem";
            this.removeUserToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.removeUserToolStripMenuItem.Text = "Remove user";
            this.removeUserToolStripMenuItem.Click += new System.EventHandler(this.removeUser);
            // 
            // rolesManagementToolStripMenuItem
            // 
            this.rolesManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seeAllRolesToolStripMenuItem,
            this.addNewRoleToolStripMenuItem,
            this.removeRoleToolStripMenuItem});
            this.rolesManagementToolStripMenuItem.Name = "rolesManagementToolStripMenuItem";
            this.rolesManagementToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.rolesManagementToolStripMenuItem.Text = "Roles management";
            // 
            // seeAllRolesToolStripMenuItem
            // 
            this.seeAllRolesToolStripMenuItem.Name = "seeAllRolesToolStripMenuItem";
            this.seeAllRolesToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.seeAllRolesToolStripMenuItem.Text = "See all roles";
            this.seeAllRolesToolStripMenuItem.Click += new System.EventHandler(this.seeAllRoles);
            // 
            // addNewRoleToolStripMenuItem
            // 
            this.addNewRoleToolStripMenuItem.Name = "addNewRoleToolStripMenuItem";
            this.addNewRoleToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.addNewRoleToolStripMenuItem.Text = "Add new role ";
            this.addNewRoleToolStripMenuItem.Click += new System.EventHandler(this.addNewRole);
            // 
            // removeRoleToolStripMenuItem
            // 
            this.removeRoleToolStripMenuItem.Name = "removeRoleToolStripMenuItem";
            this.removeRoleToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.removeRoleToolStripMenuItem.Text = "Remove role";
            this.removeRoleToolStripMenuItem.Click += new System.EventHandler(this.removeRole);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Home";
            this.Text = "Home";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersManagementToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem seeUserDetailsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem seeYourBooksToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem borrowBookToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem seeAvailableBooksToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem removeBookToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem seeAllUsersToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem removeUserToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem seeAllRolesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addNewRoleToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem removeRoleToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menu;
        public System.Windows.Forms.ToolStripMenuItem booksManagementToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem rolesManagementToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem userPanelToolStripMenuItem;
    }
}