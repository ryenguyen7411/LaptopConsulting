using System;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Laptop_Resuilt
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();

            CoreSystem.init();
        }

        private void btn_analyze_Click(object sender, EventArgs e)
        {
            var checkedButton = panel_mode.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            int a = 0;
        }
    }
}