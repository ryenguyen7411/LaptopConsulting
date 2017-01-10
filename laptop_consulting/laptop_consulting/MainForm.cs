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
            //CoreSystem.ForwardChaining(GetUserInputValues());

           // string input = textBox1.Text;
            //string[] s = input.Split(',');
            Dictionary<string, string> array_input = new Dictionary<string, string>();

            array_input.Add("Ram", "2GB");
            array_input.Add("stronge", "4.5");
            /* for(int i=0;i< s.Count();i++)
             {
                 string[] k = s[i].Split(':');
                 array_input.Add(k[0].ToString(), k[1].ToString());



             }*/
            Dictionary<int, Laptop.m_laptop> output = new Dictionary<int, Laptop.m_laptop>();
            output = CoreSystem.ForwardChaining(array_input);
            string say = "";
            for (int i = 0; i < output.Count; i++)
            {

                Laptop.m_laptop obj = new Laptop.m_laptop();
                obj = (Laptop.m_laptop)output[i];
                say= say + "\r\n" + obj._name.ToString();


            }
            MessageBox.Show(say.ToString() ,"Thông báo");
        }

        private Dictionary<string, string> GetUserInputValues()
        {
            Dictionary<string, string> _inputValues = new Dictionary<string, string>();

            var _ram = panel_ram.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
            if(_ram.Text.CompareTo("All") == 0)
            {
                _inputValues.Add(Constants.RAM, _ram.Text);
            }

            var _cpu = panel_cpu.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
            if (_cpu.Text.CompareTo("All") == 0)
            {
                _inputValues.Add(Constants.CPU, _cpu.Text);
            }

            var _storage = panel_storage.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
            if (_storage.Text.CompareTo("All") == 0)
            {
                _inputValues.Add(Constants.STORAGE, _storage.Text);
            }

            return _inputValues;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }
    }
}