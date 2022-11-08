using Cdr.AppLayer;
using Cdr.Infrastructer;
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
    public partial class FrmRemoveCategory : Form
    {
        private readonly ICategoryService categoryService;

        public FrmRemoveCategory()
        {
            InitializeComponent();
            categoryService=IOCContainer.Resolve<ICategoryService>();
        }

        private void RemoveCategory_Click(object sender, EventArgs e)
        {
            try
            {
                //categoryService.Creat(txtCategoryName.Text);
                categoryService.RemoveCategory(txtRemoveBeforeCategoryName.Text,txtRemoveNewCategoryName.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }
        }
    }
}
