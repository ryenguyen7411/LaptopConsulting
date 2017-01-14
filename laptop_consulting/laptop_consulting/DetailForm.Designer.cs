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
            this.listview_detail = new MaterialSkin.Controls.MaterialListView();
            this.col_detail_property = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_detail_value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // lbl_detail_price
            // 
            this.lbl_detail_price.AutoSize = true;
            this.lbl_detail_price.Depth = 0;
            this.lbl_detail_price.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_detail_price.Location = new System.Drawing.Point(407, 88);
            this.lbl_detail_price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_detail_price.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_detail_price.Name = "lbl_detail_price";
            this.lbl_detail_price.Size = new System.Drawing.Size(43, 19);
            this.lbl_detail_price.TabIndex = 0;
            this.lbl_detail_price.Text = "Price";
            // 
            // listview_detail
            // 
            this.listview_detail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listview_detail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_detail_property,
            this.col_detail_value});
            this.listview_detail.Depth = 0;
            this.listview_detail.Font = new System.Drawing.Font("Roboto", 18F);
            this.listview_detail.FullRowSelect = true;
            this.listview_detail.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listview_detail.Location = new System.Drawing.Point(136, 132);
            this.listview_detail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listview_detail.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listview_detail.MouseState = MaterialSkin.MouseState.OUT;
            this.listview_detail.Name = "listview_detail";
            this.listview_detail.OwnerDraw = true;
            this.listview_detail.Size = new System.Drawing.Size(504, 202);
            this.listview_detail.TabIndex = 1;
            this.listview_detail.UseCompatibleStateImageBehavior = false;
            this.listview_detail.View = System.Windows.Forms.View.Details;
            // 
            // col_detail_property
            // 
            this.col_detail_property.Text = "Name";
            this.col_detail_property.Width = 210;
            // 
            // col_detail_value
            // 
            this.col_detail_value.Text = "Value";
            this.col_detail_value.Width = 223;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(8, 356);
            this.materialRaisedButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(50, 26);
            this.materialRaisedButton1.TabIndex = 2;
            this.materialRaisedButton1.Text = "Back";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 390);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.listview_detail);
            this.Controls.Add(this.lbl_detail_price);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DetailForm";
            this.Text = "DetailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl_detail_price;
        private MaterialSkin.Controls.MaterialListView listview_detail;
        private System.Windows.Forms.ColumnHeader col_detail_property;
        private System.Windows.Forms.ColumnHeader col_detail_value;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}