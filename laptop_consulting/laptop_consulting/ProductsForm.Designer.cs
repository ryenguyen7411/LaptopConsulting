namespace Laptop_Resuilt
{
    partial class ProductsForm
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
            this.listview_product = new MaterialSkin.Controls.MaterialListView();
            this.column_product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_back_products = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // listview_product
            // 
            this.listview_product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listview_product.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_product});
            this.listview_product.Depth = 0;
            this.listview_product.Font = new System.Drawing.Font("Roboto", 18F);
            this.listview_product.FullRowSelect = true;
            this.listview_product.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listview_product.Location = new System.Drawing.Point(0, 65);
            this.listview_product.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listview_product.MouseState = MaterialSkin.MouseState.OUT;
            this.listview_product.Name = "listview_product";
            this.listview_product.OwnerDraw = true;
            this.listview_product.Size = new System.Drawing.Size(1024, 458);
            this.listview_product.TabIndex = 0;
            this.listview_product.UseCompatibleStateImageBehavior = false;
            this.listview_product.View = System.Windows.Forms.View.Details;
            this.listview_product.DoubleClick += new System.EventHandler(this.listview_product_DoubleClick);
            // 
            // column_product
            // 
            this.column_product.Text = "Product";
            this.column_product.Width = 623;
            // 
            // btn_back_products
            // 
            this.btn_back_products.Depth = 0;
            this.btn_back_products.Location = new System.Drawing.Point(12, 549);
            this.btn_back_products.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_back_products.Name = "btn_back_products";
            this.btn_back_products.Primary = true;
            this.btn_back_products.Size = new System.Drawing.Size(96, 39);
            this.btn_back_products.TabIndex = 1;
            this.btn_back_products.Text = "Back";
            this.btn_back_products.UseVisualStyleBackColor = true;
            this.btn_back_products.Click += new System.EventHandler(this.btn_back_products_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.btn_back_products);
            this.Controls.Add(this.listview_product);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listview_product;
        private System.Windows.Forms.ColumnHeader column_product;
        private MaterialSkin.Controls.MaterialRaisedButton btn_back_products;
    }
}