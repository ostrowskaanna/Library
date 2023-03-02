namespace LibraryProject.Forms
{
    partial class NewUserForm
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancelButton = new System.Windows.Forms.Button();
            this.confButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwdTextBox = new System.Windows.Forms.TextBox();
            this.rolesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(242, 360);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(123, 30);
            this.cancelButton.TabIndex = 22;
            this.cancelButton.Text = "cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancel);
            // 
            // confButton
            // 
            this.confButton.Enabled = false;
            this.confButton.Location = new System.Drawing.Point(399, 360);
            this.confButton.Name = "confButton";
            this.confButton.Size = new System.Drawing.Size(123, 31);
            this.confButton.TabIndex = 21;
            this.confButton.Text = "confirm";
            this.confButton.UseVisualStyleBackColor = true;
            this.confButton.Click += new System.EventHandler(this.confirm);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(339, 101);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(112, 16);
            this.infoLabel.TabIndex = 20;
            this.infoLabel.Text = "enter user details:";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(240, 303);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(33, 16);
            this.roleLabel.TabIndex = 18;
            this.roleLabel.Text = "role:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(342, 195);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(180, 22);
            this.emailTextBox.TabIndex = 17;
            this.emailTextBox.TextChanged += new System.EventHandler(this.checkIfDataComplete);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(342, 143);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(180, 22);
            this.usernameTextBox.TabIndex = 16;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.checkIfDataComplete);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(239, 249);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 16);
            this.passwordLabel.TabIndex = 15;
            this.passwordLabel.Text = "password:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(240, 198);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(43, 16);
            this.emailLabel.TabIndex = 14;
            this.emailLabel.Text = "email:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(240, 146);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(70, 16);
            this.usernameLabel.TabIndex = 13;
            this.usernameLabel.Text = "username:";
            // 
            // passwdTextBox
            // 
            this.passwdTextBox.Location = new System.Drawing.Point(342, 249);
            this.passwdTextBox.Name = "passwdTextBox";
            this.passwdTextBox.Size = new System.Drawing.Size(180, 22);
            this.passwdTextBox.TabIndex = 23;
            this.passwdTextBox.TextChanged += new System.EventHandler(this.checkIfDataComplete);
            // 
            // rolesListBox
            // 
            this.rolesListBox.FormattingEnabled = true;
            this.rolesListBox.ItemHeight = 16;
            this.rolesListBox.Location = new System.Drawing.Point(342, 303);
            this.rolesListBox.Name = "rolesListBox";
            this.rolesListBox.Size = new System.Drawing.Size(180, 36);
            this.rolesListBox.TabIndex = 24;
            this.rolesListBox.SelectedIndexChanged += new System.EventHandler(this.checkIfDataComplete);
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rolesListBox);
            this.Controls.Add(this.passwdTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.usernameLabel);
            this.Name = "NewUserForm";
            this.Size = new System.Drawing.Size(834, 559);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.Button confButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label roleLabel;
        public System.Windows.Forms.TextBox emailTextBox;
        public System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label usernameLabel;
        public System.Windows.Forms.TextBox passwdTextBox;
        public System.Windows.Forms.ListBox rolesListBox;
    }
}
