using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cdr.Presentation.WinFormUI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }


        private void AddNewCategory_Click(object sender, EventArgs e)
        {
            var form = new FrmNewCategory();
            form.ShowDialog();
        }
        

        private void AddNewProduct_Click(object sender, EventArgs e)
        {
            var form = new FrmNewProduct();
            form.ShowDialog();
        }

        private void DeleteCategory_Click(object sender, EventArgs e)
        {
            var form = new FrmDeleteCategory();
            form.ShowDialog();
        }

        private void RemoveCategory_Click(object sender, EventArgs e)
        {
            var form = new FrmRemoveCategory();
            form.ShowDialog();
        }

        private void FrmCategoryList_Click(object sender, EventArgs e)
        {
            var form = new FrmListCategory();
            form.ShowDialog();
        }

        private void FrmListProduct_Click(object sender, EventArgs e)
        {
            var form = new FrmListProduct();
            form.ShowDialog();
        }
    }
}
