namespace Laptop_Resuilt
{
    partial class DetailForm
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
            this.lbl_detail_price = new MaterialSkin.Controls.MaterialLabel();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.col_detail_property = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_detail_value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lbl_detail_price
            // 
            this.lbl_detail_price.AutoSize = true;
            this.lbl_detail_price.Depth = 0;
            this.lbl_detail_price.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_detail_price.Location = new System.Drawing.Point(611, 136);
            this.lbl_detail_price.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_detail_price.Name = "lbl_detail_price";
            this.lbl_detail_price.Size = new System.Drawing.Size(62, 27);
            this.lbl_detail_price.TabIndex = 0;
            this.lbl_detail_price.Text = "Price";
            // 
            // materialListView1
            // 
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_detail_property,
            this.col_detail_value});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Roboto", 18F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.Location = new System.Drawing.Point(526, 203);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(433, 311);
            this.materialListView1.TabIndex = 1;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // col_detail_property
            // 
            this.col_detail_property.Text = "";
            this.col_detail_property.Width = 210;
            // 
            // col_detail_value
            // 
            this.col_detail_value.Text = "";
            this.col_detail_value.Width = 223;
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.materialListView1);
            this.Controls.Add(this.lbl_detail_price);
            this.Name = "DetailForm";
            this.Text = "DetailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl_detail_price;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader col_detail_property;
        private System.Windows.Forms.ColumnHeader col_detail_value;
    }
}