namespace Cdr.Presentation.WinFormUI
{
    partial class FrmRemoveCategory
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
            this.lblRemoveCategoryName = new System.Windows.Forms.Label();
            this.txtRemoveBeforeCategoryName = new System.Windows.Forms.TextBox();
            this.txtRemoveNewCategoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRemoveCategoryName
            // 
            this.lblRemoveCategoryName.AutoSize = true;
            this.lblRemoveCategoryName.Location = new System.Drawing.Point(35, 36);
            this.lblRemoveCategoryName.Name = "lblRemoveCategoryName";
            this.lblRemoveCategoryName.Size = new System.Drawing.Size(152, 15);
            this.lblRemoveCategoryName.TabIndex = 0;
            this.lblRemoveCategoryName.Text = "Güncellenecek Kategori Adı";
            // 
            // txtRemoveBeforeCategoryName
            // 
            this.txtRemoveBeforeCategoryName.Location = new System.Drawing.Point(35, 54);
            this.txtRemoveBeforeCategoryName.Name = "txtRemoveBeforeCategoryName";
            this.txtRemoveBeforeCategoryName.Size = new System.Drawing.Size(152, 23);
            this.txtRemoveBeforeCategoryName.TabIndex = 1;
            // 
            // txtRemoveNewCategoryName
            // 
            this.txtRemoveNewCategoryName.Location = new System.Drawing.Point(35, 116);
            this.txtRemoveNewCategoryName.Name = "txtRemoveNewCategoryName";
            this.txtRemoveNewCategoryName.Size = new System.Drawing.Size(152, 23);
            this.txtRemoveNewCategoryName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yeni Kategori Adı";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(35, 154);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(152, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Güncelle";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.RemoveCategory_Click);
            // 
            // FrmRemoveCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtRemoveNewCategoryName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRemoveBeforeCategoryName);
            this.Controls.Add(this.lblRemoveCategoryName);
            this.Name = "FrmRemoveCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kategori Güncelleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblRemoveCategoryName;
        private TextBox txtRemoveBeforeCategoryName;
        private TextBox txtRemoveNewCategoryName;
        private Label label1;
        private Button btnRemove;
    }
}