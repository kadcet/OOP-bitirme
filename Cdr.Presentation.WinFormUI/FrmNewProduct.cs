using Cdr.AppLayer;
using Cdr.Domain.Entities;
using Cdr.Infrastructer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cdr.Presentation.WinFormUI
{
    public partial class FrmNewProduct : Form
    {


        private readonly ICategoryService categoryService;
        private readonly IProductService productService;

        public FrmNewProduct()
        {
            InitializeComponent();
            productService = IOCContainer.Resolve<IProductService>();
            categoryService = IOCContainer.Resolve<ICategoryService>();
        }

        private void FrmNewProduct_Load(object sender, EventArgs e)
        {
            var categoryList = categoryService.GetAllCategories();
            // seçtiğim zaman GUİD değerini yani Id versin.  Ekranda name sini göstersin

            cmbCategories.DataSource = categoryList;
            cmbCategories.DisplayMember = "Name";  // Property nin adını yazıyorum.
            cmbCategories.ValueMember = "Id";

            //foreach (Category item in categoryList)
            //{
            //    cmbCategories.Items.Add(item.Name);
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                productService.Create(txtUrunAdi.Text, Convert.ToDecimal(txtFiyat.Text), Convert.ToInt32(txtStokMiktari.Text), Convert.ToDecimal(txtTax.Text), cmbCategories.SelectedValue.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }

            //var categoryId1 = cmbCategories.SelectedIndex;
            //var categoryId2 = cmbCategories.SelectedItem;
            //var categoryId3 = cmbCategories.SelectedText;
            //var categoryId4 = cmbCategories.SelectedValue;
        }

        
    }
}
