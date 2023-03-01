using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryProject.Logics;

namespace LibraryProject.Forms
{
    public partial class Change : Form
    {
        ChangeLogic logic = new ChangeLogic();
        int userId;
        string dataToChange;
        public Change()
        {
            InitializeComponent();
            logic.getForm(this);
        }

        public void getData(string name, int id)
        {
            this.dataToChange = name;
            this.userId = id;
            this.logic.getId(this.userId);
            if(name == "changePasswordButton")
            {
                this.oldPassword.Visible = true;
                this.oldPasswordLabel.Visible = true;
                this.newData.PasswordChar = '*';
                this.newDataLabel.Text = "new password: ";
            }
            else if(name == "changeUsernameButton")
            {
                this.newDataLabel.Text = "new username: ";
            }
            else if(name == "changeEmailButton")
            {
                this.newDataLabel.Text = "new email: ";
            }
        }

        private void confirmChanges(object sender, EventArgs e)
        {
            this.logic.changeDataInDB(this.oldPassword, this.newData);
        }

        private void dataEntered(object sender, EventArgs e)
        {
            this.logic.checkIfClickEnable(this.oldPassword, this.newData, this.confirmButton, this.dataToChange);
        }

        private void closeChangingForm(object sender, EventArgs e)
        {
            this.logic.closeForm();
        }
    }
}
