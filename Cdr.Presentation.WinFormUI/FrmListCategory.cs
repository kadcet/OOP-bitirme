using Cdr.AppLayer;
using Cdr.Domain.Entities;
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
    public partial class FrmListCategory : Form
    {
        public FrmListCategory()
        {
            InitializeComponent();
        }

        private void ListCategory_Load(object sender, EventArgs e)
        {
            List<Category> categories = new List<Category>();
            var categoryService = new CategoryService();
            categories = categoryService.GetAllCategories().ToList();
            
            dgwCategory.DataSource = categories;
            dgwCategory.Columns[0].HeaderText = "Kategori Adı";
            dgwCategory.Columns[1].Visible = false;
            
        }
    }
}
