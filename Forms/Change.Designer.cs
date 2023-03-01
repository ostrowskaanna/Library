namespace LibraryProject.Forms
{
    partial class Change
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
            this.oldPassword = new System.Windows.Forms.TextBox();
            this.newData = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.oldPasswordLabel = new System.Windows.Forms.Label();
            this.newDataLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oldPassword
            // 
            this.oldPassword.Location = new System.Drawing.Point(159, 56);
            this.oldPassword.Name = "oldPassword";
            this.oldPassword.PasswordChar = '*';
            this.oldPassword.Size = new System.Drawing.Size(116, 22);
            this.oldPassword.TabIndex = 1;
            this.oldPassword.Visible = false;
            this.oldPassword.TextChanged += new System.EventHandler(this.dataEntered);
            // 
            // newData
            // 
            this.newData.Location = new System.Drawing.Point(159, 122);
            this.newData.Name = "newData";
            this.newData.Size = new System.Drawing.Size(116, 22);
            this.newData.TabIndex = 2;
            this.newData.TextChanged += new System.EventHandler(this.dataEntered);
            // 
            // confirmButton
            // 
            this.confirmButton.Enabled = false;
            this.confirmButton.Location = new System.Drawing.Point(159, 180);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(116, 23);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmChanges);
            // 
            // oldPasswordLabel
            // 
            this.oldPasswordLabel.AutoSize = true;
            this.oldPasswordLabel.Location = new System.Drawing.Point(34, 59);
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.oldPasswordLabel.Size = new System.Drawing.Size(91, 16);
            this.oldPasswordLabel.TabIndex = 4;
            this.oldPasswordLabel.Text = "old password:";
            this.oldPasswordLabel.Visible = false;
            // 
            // newDataLabel
            // 
            this.newDataLabel.AutoSize = true;
            this.newDataLabel.Location = new System.Drawing.Point(34, 125);
            this.newDataLabel.Name = "newDataLabel";
            this.newDataLabel.Size = new System.Drawing.Size(44, 16);
            this.newDataLabel.TabIndex = 5;
            this.newDataLabel.Text = "label2";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(37, 180);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(116, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.closeChangingForm);
            // 
            // Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 263);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.newDataLabel);
            this.Controls.Add(this.oldPasswordLabel);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.newData);
            this.Controls.Add(this.oldPassword);
            this.Name = "Change";
            this.Text = "Change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox oldPassword;
        public System.Windows.Forms.TextBox newData;
        public System.Windows.Forms.Button confirmButton;
        public System.Windows.Forms.Label oldPasswordLabel;
        public System.Windows.Forms.Label newDataLabel;
        private System.Windows.Forms.Button cancelButton;
    }
}