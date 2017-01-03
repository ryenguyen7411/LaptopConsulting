using System;
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
<<<<<<< HEAD
=======
            var checkedButton = panel_mode.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);

            int a = 0;
>>>>>>> 84af773b498c8c302f0c68aca341b34e197283e0
        }
    }
}