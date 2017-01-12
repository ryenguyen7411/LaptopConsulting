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

            lbl_detail_price.Text = data._outside.price + "$";

            ListViewItem name = new ListViewItem("Name");
            name.SubItems.Add(data._name);
            listview_detail.Items.Add(name);

            ListViewItem cpu = new ListViewItem("CPU");
            cpu.SubItems.Add(data._cpu.m_name);
            listview_detail.Items.Add(cpu);

            ListViewItem gpu = new ListViewItem("GPU");
            gpu.SubItems.Add(data._gpu.m_name);
            listview_detail.Items.Add(gpu);

            ListViewItem screenResolution = new ListViewItem("Resolution");
            screenResolution.SubItems.Add(data._screen._screenResolution);
            listview_detail.Items.Add(screenResolution);

            ListViewItem screenSize = new ListViewItem("Screen size");
            screenSize.SubItems.Add(data._screen._screenSize);
            listview_detail.Items.Add(screenSize);

            ListViewItem battery = new ListViewItem("Battery");
            battery.SubItems.Add(data._battery._capacity);
            listview_detail.Items.Add(battery);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
