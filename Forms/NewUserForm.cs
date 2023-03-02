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
    public partial class NewUserForm : UserControl
    {
        NewUserFormLogic logic = new NewUserFormLogic();
        public NewUserForm()
        {
            InitializeComponent();
            this.logic.getForm(this);
        }

        private void confirm(object sender, EventArgs e)
        {
            this.logic.addUserToDB();
        }

        private void cancel(object sender, EventArgs e)
        {
            this.logic.clearForm();
        }

        private void checkIfDataComplete(object sender, EventArgs e)
        {
            this.logic.checkIfDataComplete();
        }
    }
}
