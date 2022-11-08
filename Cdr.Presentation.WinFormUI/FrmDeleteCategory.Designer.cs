namespace Cdr.Presentation.WinFormUI
{
    partial class FrmDeleteCategory
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
            this.txtDeleteCategoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDeleteCategoryName
            // 
            this.txtDeleteCategoryName.Location = new System.Drawing.Point(26, 51);
            this.txtDeleteCategoryName.Name = "txtDeleteCategoryName";
            this.txtDeleteCategoryName.Size = new System.Drawing.Size(139, 23);
            this.txtDeleteCategoryName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Silinecek Kategori Girinizi";
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(26, 80);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(139, 23);
            this.btnDeleteCategory.TabIndex = 2;
            this.btnDeleteCategory.Text = "Sil";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.DeleteCategoryName_Click);
            // 
            // FrmDeleteCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDeleteCategoryName);
            this.Name = "FrmDeleteCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmDeleteCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtDeleteCategoryName;
        private Label label1;
        private Button btnDeleteCategory;
    }
}