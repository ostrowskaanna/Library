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

namespace LibraryProject
{
    public partial class Registration : Form
    {
        RegistrationLogic logic = new RegistrationLogic();
        public Registration()
        {
            InitializeComponent();
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxConfirm.PasswordChar = '*';
            this.logic.getForm(this, this.textBoxUsername, this.textBoxEmail, this.textBoxPassword, this.textBoxConfirm, this.signInButton, this.signUpButton);
        }

        private void singIn(object sender, EventArgs e)
        {
            if (logic.checkIfLoginDataCorrect())
            {
                logic.openHomeForm();
            }
            else
                MessageBox.Show("wrong login data!");
                
        }

        private void signUp(object sender, EventArgs e)
        {
            if (logic.checkIfDataIsCorrect() && logic.checkPassword() && !logic.checkIfExists())
            {
                logic.addToDB();
                logic.openHomeForm();
            }
        }

        private void checkIfSignInEnabled(object sender, EventArgs e)
        {
            logic.checkIfSignInEnabled();
        }

        private void checkIfSignUpEnabled(object sender, EventArgs e)
        {
            logic.checkIfSignUpEnabled();
        }

    }

}
