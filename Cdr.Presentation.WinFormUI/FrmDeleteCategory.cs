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
    public partial class FrmDeleteCategory : Form
    {
        private readonly ICategoryService categoryService;

        public FrmDeleteCategory()
        {
            InitializeComponent();
            categoryService = IOCContainer.Resolve<ICategoryService>();
        }

        private void DeleteCategoryName_Click(object sender, EventArgs e)
        {
            try
            {
                categoryService.DeleteCategory(txtDeleteCategoryName.Text);
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
