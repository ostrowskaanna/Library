using LibraryProject.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryProject.Logics;
using LibraryProject.DataModels;

namespace LibraryProject.Forms
{
    public partial class BooksView : UserControl
    {
        BooksViewLogic logic = new BooksViewLogic();
        int id;
        Role role;
        public BooksView()
        {
            InitializeComponent();
            this.logic.getForm(this, this.dataGridView1, this.infoLabel, this.confirmButton);
        }

        public void getData(int id, Role role)
        {
            this.id = id;
            this.role = role;
        }

        public void loadData(bool all, bool choose)
        {
            this.logic.loadData(all, choose, this.id, this.role);
        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.logic.cellClick(e);
        }

        private void confirmBook(object sender, EventArgs e)
        {
            this.logic.confirmBook();
        }
    }
}
