using Cdr.AppLayer;
using Cdr.Infrastructer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Cdr.Presentation.WinFormUI
{
    public partial class FrmNewCategory : Form
    {
        // category servisine ulaşmamız lazım
        private readonly ICategoryService categoryService;

        public FrmNewCategory()
        {
            InitializeComponent();
            // CategoryServisi new le türetmiyoruz
            categoryService = IOCContainer.Resolve<ICategoryService>();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //string categoryName = txtCategoryName.Text;
            //categoryService.Creat(categoryName);
            try
            {
                categoryService.Creat(txtCategoryName.Text);
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
