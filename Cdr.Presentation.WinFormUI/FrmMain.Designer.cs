namespace Cdr.Presentation.WinFormUI
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.kategoriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriİşlemleriToolStripMenuItem,
            this.ürünİşlemleriToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(800, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // kategoriİşlemleriToolStripMenuItem
            // 
            this.kategoriİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKategoriToolStripMenuItem,
            this.kategoriListesiToolStripMenuItem,
            this.kategoriSilToolStripMenuItem,
            this.kategoriGüncelleToolStripMenuItem});
            this.kategoriİşlemleriToolStripMenuItem.Name = "kategoriİşlemleriToolStripMenuItem";
            this.kategoriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.kategoriİşlemleriToolStripMenuItem.Text = "Kategori İşlemleri";
            // 
            // yeniKategoriToolStripMenuItem
            // 
            this.yeniKategoriToolStripMenuItem.Name = "yeniKategoriToolStripMenuItem";
            this.yeniKategoriToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.yeniKategoriToolStripMenuItem.Text = "Yeni Kategori";
            this.yeniKategoriToolStripMenuItem.Click += new System.EventHandler(this.AddNewCategory_Click);
            // 
            // kategoriListesiToolStripMenuItem
            // 
            this.kategoriListesiToolStripMenuItem.Name = "kategoriListesiToolStripMenuItem";
            this.kategoriListesiToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.kategoriListesiToolStripMenuItem.Text = "Kategori Listesi";
            this.kategoriListesiToolStripMenuItem.Click += new System.EventHandler(this.FrmCategoryList_Click);
            // 
            // kategoriSilToolStripMenuItem
            // 
            this.kategoriSilToolStripMenuItem.Name = "kategoriSilToolStripMenuItem";
            this.kategoriSilToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.kategoriSilToolStripMenuItem.Text = "Kategori Sil";
            this.kategoriSilToolStripMenuItem.Click += new System.EventHandler(this.DeleteCategory_Click);
            // 
            // kategoriGüncelleToolStripMenuItem
            // 
            this.kategoriGüncelleToolStripMenuItem.Name = "kategoriGüncelleToolStripMenuItem";
            this.kategoriGüncelleToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.kategoriGüncelleToolStripMenuItem.Text = "Kategori Güncelle";
            this.kategoriGüncelleToolStripMenuItem.Click += new System.EventHandler(this.RemoveCategory_Click);
            // 
            // ürünİşlemleriToolStripMenuItem
            // 
            this.ürünİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünEkleToolStripMenuItem,
            this.ürünListesiToolStripMenuItem});
            this.ürünİşlemleriToolStripMenuItem.Name = "ürünİşlemleriToolStripMenuItem";
            this.ürünİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.ürünİşlemleriToolStripMenuItem.Text = "Ürün İşlemleri";
            // 
            // ürünEkleToolStripMenuItem
            // 
            this.ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem";
            this.ürünEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ürünEkleToolStripMenuItem.Text = "Ürün Ekle";
            this.ürünEkleToolStripMenuItem.Click += new System.EventHandler(this.AddNewProduct_Click);
            // 
            // ürünListesiToolStripMenuItem
            // 
            this.ürünListesiToolStripMenuItem.Name = "ürünListesiToolStripMenuItem";
            this.ürünListesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ürünListesiToolStripMenuItem.Text = "Ürün Listesi";
            this.ürünListesiToolStripMenuItem.Click += new System.EventHandler(this.FrmListProduct_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coder ERP v.1.0";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mainMenu;
        private ToolStripMenuItem kategoriİşlemleriToolStripMenuItem;
        private ToolStripMenuItem yeniKategoriToolStripMenuItem;
        private ToolStripMenuItem kategoriListesiToolStripMenuItem;
        private ToolStripMenuItem ürünİşlemleriToolStripMenuItem;
        private ToolStripMenuItem ürünEkleToolStripMenuItem;
        private ToolStripMenuItem ürünListesiToolStripMenuItem;
        private ToolStripMenuItem kategoriSilToolStripMenuItem;
        private ToolStripMenuItem kategoriGüncelleToolStripMenuItem;
    }
}