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

            //  array_input.Add("Ram", "2GB");
            //  array_input.Add("stronge", "4.5");
            array_input = GetUserInputValues();
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
            if(_ram.Text.CompareTo("All") != 0)
            {
                AddStandardized(ref _inputValues, Constants.RAM, _ram.Text);
            }

            var _cpu = panel_cpu.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
            if (_cpu.Text.CompareTo("All") != 0)
            {
                AddStandardized(ref _inputValues, Constants.CPU, _cpu.Text);
            }

            var _storage = panel_storage.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
            if (_storage.Text.CompareTo("All") != 0)
            {
                AddStandardized(ref _inputValues, Constants.STORAGE, _storage.Text);
            }

            var _screenSize = panel_screen.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
            if(_screenSize.Text.CompareTo("All") != 0)
            {
                AddStandardized(ref _inputValues, Constants.SCREENSIZE, _screenSize.Text);
            }

            var _demand = panel_demand.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
            if (_demand.Text.CompareTo("All") != 0)
            {
                AddStandardized(ref _inputValues, "DEMAND", _demand.Text);
            }

            var _prices = panel_screen.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
            if (_prices.Text.CompareTo("All") != 0)
            {
                AddStandardized(ref _inputValues, Constants.PRICE, _prices.Text);
            }

            return _inputValues;
        }

        private void AddStandardized(ref Dictionary<string, string> input, string tag, string value)
        {
            if(tag.CompareTo(Constants.RAM) == 0)
            {
                input.Add(Constants.RAM, value);
            }
            else if(tag.CompareTo(Constants.CPU) == 0)
            {
                switch (value)
                {
                    case "Celeron":
                    case "Core M":
                        input.Add(Constants.CPU, value);
                        break;
                    case "Core i3":
                        input.Add(Constants.CPU, "i3");
                        break;
                    case "Core i5":
                        input.Add(Constants.CPU, "i5");
                        break;
                    case "Core i7":
                        input.Add(Constants.CPU, "i7");
                        break;
                    default:
                        break;
                }
            }
            else if(tag.CompareTo(Constants.STORAGE) == 0)
            {
                string[] _values = value.Split(' ');
                input.Add(Constants.STORAGE, _values[0]);
                input.Add(Constants.STORAGE, _values[1]);
            }
            else if (tag.CompareTo(Constants.SCREENSIZE) == 0)
            {
                input.Add(Constants.SCREENSIZE, value);
            }
            else if (tag.CompareTo("DEMAND") == 0)
            {
                switch (value)
                {
                    case "Offices":
                        input.Add(Constants.RAM, "2GB");
                        input.Add(Constants.CPU, "Core M");
                        input.Add(Constants.GPU, "HD Graphics");
                        input.Add(Constants.STORAGE, "HDD");
                        input.Add(Constants.STORAGE, "500GB");
                        break;
                    case "Gaming":
                        input.Add(Constants.RAM, "8GB");
                        input.Add(Constants.CPU, "Core i7");
                        input.Add(Constants.GPU, "GTX");
                        input.Add(Constants.STORAGE, "HDD");
                        input.Add(Constants.STORAGE, "1TB");
                        break;
                    case "Graphics":
                        input.Add(Constants.RAM, "8GB");
                        input.Add(Constants.CPU, "i7");
                        input.Add(Constants.GPU, "GTX");
                        input.Add(Constants.STORAGE, "SSD");
                        input.Add(Constants.STORAGE, "512GB");
                        break;
                    case "Fashion":
                        input.Add(Constants.WEIGHT, "4");
                        break;
                    default:
                        break;
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }
    }
}