using System;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Collections.Generic;

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
            CoreSystem.ForwardChaining(GetUserInputValues());
        }

        private Dictionary<string, string> GetUserInputValues()
        {
            Dictionary<string, string> _inputValues = new Dictionary<string, string>();

            var _ram = panel_ram.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
            _inputValues.Add(Constants.RAM, _ram.Text);

            var _cpu = panel_cpu.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
            _inputValues.Add(Constants.CPU, _cpu.Text);

            var _storage = panel_storage.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
            _inputValues.Add(Constants.STORAGE, _storage.Text);

            return _inputValues;
        }
    }
}