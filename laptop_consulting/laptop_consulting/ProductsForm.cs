using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laptop_Resuilt
{
    public partial class ProductsForm : MaterialForm
    {
        public Dictionary<int, Laptop.m_laptop> data;

        public ProductsForm(Dictionary<int, Laptop.m_laptop> output)
        {
            InitializeComponent();

            data = output;
            for(int i = 0; i < data.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(data.ElementAt(i).Value._name);
                listview_product.Items.Add(item);
            }
        }

        private void btn_back_products_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
