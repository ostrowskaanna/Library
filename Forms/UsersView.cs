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
    public partial class UsersView : UserControl
    {
        UsersViewLogic logic = new UsersViewLogic();
        public UsersView()
        {
            InitializeComponent();
            this.logic.getForm(this);
        }

        public void loadData(bool action)
        {
            this.logic.loadData();
            this.logic.setForm(action);
        }

        private void confirmUser(object sender, EventArgs e)
        {
            this.logic.confirmUser();
        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.logic.cellClick(e);
        }
    }
}
