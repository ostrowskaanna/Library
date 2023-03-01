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
    public partial class NewBookForm : UserControl
    {
        NewBookFormLogic logic = new NewBookFormLogic();
 
        public NewBookForm()
        {
            InitializeComponent();
            this.logic.getForm(this);
        }

        private void checkIfDataComplete(object sender, EventArgs e)
        {
            this.logic.checkIfDataComplete();
        }

        private void addBookToDB(object sender, EventArgs e)
        {
            this.logic.addBookToDB();
        }

        private void clearForm(object sender, EventArgs e)
        {
            this.logic.clearForm();
        }
    }
}
