namespace LibraryProject.Forms
{
    partial class NewBookForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.descLabel = new System.Windows.Forms.Label();
            this.descTextBox = new System.Windows.Forms.RichTextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.confButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.quantityNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(237, 100);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(33, 16);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "title: ";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(237, 152);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(50, 16);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "author: ";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(236, 203);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(56, 16);
            this.quantityLabel.TabIndex = 2;
            this.quantityLabel.Text = "quantity:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(339, 97);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(180, 22);
            this.titleTextBox.TabIndex = 3;
            this.titleTextBox.TextChanged += new System.EventHandler(this.checkIfDataComplete);
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(339, 149);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(180, 22);
            this.authorTextBox.TabIndex = 4;
            this.authorTextBox.TextChanged += new System.EventHandler(this.checkIfDataComplete);
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(237, 257);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(79, 16);
            this.descLabel.TabIndex = 7;
            this.descLabel.Text = "description: ";
            // 
            // descTextBox
            // 
            this.descTextBox.Location = new System.Drawing.Point(339, 257);
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(180, 100);
            this.descTextBox.TabIndex = 8;
            this.descTextBox.Text = "";
            this.descTextBox.TextChanged += new System.EventHandler(this.checkIfDataComplete);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(336, 55);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(117, 16);
            this.infoLabel.TabIndex = 9;
            this.infoLabel.Text = "enter book details:";
            // 
            // confButton
            // 
            this.confButton.Enabled = false;
            this.confButton.Location = new System.Drawing.Point(396, 391);
            this.confButton.Name = "confButton";
            this.confButton.Size = new System.Drawing.Size(123, 31);
            this.confButton.TabIndex = 10;
            this.confButton.Text = "confirm";
            this.confButton.UseVisualStyleBackColor = true;
            this.confButton.Click += new System.EventHandler(this.addBookToDB);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(239, 392);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(123, 30);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.clearForm);
            // 
            // quantityNumeric
            // 
            this.quantityNumeric.Location = new System.Drawing.Point(339, 203);
            this.quantityNumeric.Name = "quantityNumeric";
            this.quantityNumeric.Size = new System.Drawing.Size(180, 22);
            this.quantityNumeric.TabIndex = 12;
            this.quantityNumeric.ValueChanged += new System.EventHandler(this.checkIfDataComplete);
            // 
            // NewBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.quantityNumeric);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "NewBookForm";
            this.Size = new System.Drawing.Size(667, 447);
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Label infoLabel;
        public System.Windows.Forms.TextBox titleTextBox;
        public System.Windows.Forms.TextBox authorTextBox;
        public System.Windows.Forms.RichTextBox descTextBox;
        public System.Windows.Forms.Button confButton;
        public System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.NumericUpDown quantityNumeric;
    }
}
