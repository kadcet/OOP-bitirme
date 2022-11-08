using Cdr.AppLayer;
using Cdr.Domain.Entities;
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
    public partial class FrmListProduct : Form
    {
        public FrmListProduct()
        {
            InitializeComponent();
        }

        private void ListProduct_Load(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            var productService = new ProductService();
            //products = productService.GetProduct();

            dgwProduct.DataSource = products;
            dgwProduct.Columns[0].HeaderText = "Kategori Adı";
            dgwProduct.Columns[1].Visible = false;
        }
    }
}
