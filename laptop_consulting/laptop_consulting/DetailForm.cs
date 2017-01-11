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
    public partial class DetailForm : MaterialForm
    {
        Laptop.m_laptop data;

        public DetailForm(Laptop.m_laptop product)
        {
            InitializeComponent();

            data = product;

            lbl_detail_price.Text = data._outside.price;

            ListViewItem cpu = new ListViewItem("CPU");
            cpu.SubItems.Add(data._cpu.m_name);
            listview_detail.Items.Add(cpu);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
