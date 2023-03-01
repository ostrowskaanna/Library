using LibraryProject.Logics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.Forms
{
    public partial class Details : UserControl
    {
        DetailsLogic logic = new DetailsLogic();
        int id;
        public Details()
        {
            InitializeComponent();
            this.logic.getForm(this);
        }

        public void getData(int id)
        {
            this.id = id;
            this.logic.getData(id);
        }

        private void changeData(object sender, EventArgs e)
        {
            string name = ((Button)sender).Name;
            this.logic.openChangeForm(name, this.id);
        }
    }
}
