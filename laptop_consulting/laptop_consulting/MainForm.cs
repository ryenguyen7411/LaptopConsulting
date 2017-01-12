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
            Dictionary<int, Laptop.m_laptop> output = CoreSystem.ForwardChaining(GetUserInputValues());

            if (output.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm phù hợp yêu cầu.", "Message");
                return;
            }

            ProductsForm _productsForm = new ProductsForm(output);
            _productsForm.Show();
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

            var _prices = panel_price.Controls.OfType<RadioButton>()
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
                input[Constants.RAM] = value;
            }
            else if(tag.CompareTo(Constants.CPU) == 0)
            {
                switch (value)
                {
                    case "Celeron":
                    case "Core M":
                        input[Constants.CPU] = value;
                        break;
                    case "Core i3":
                        input[Constants.CPU] = "i3";
                        break;
                    case "Core i5":
                        input[Constants.CPU] = "i5";
                        break;
                    case "Core i7":
                        input[Constants.CPU] = "i7";
                        break;
                    default:
                        break;
                }
            }
            else if(tag.CompareTo(Constants.STORAGE) == 0)
            {
                string[] _values = value.Split(' ');
                input[Constants.STORAGE + "_type"] = _values[0];
                input[Constants.STORAGE + "_value"] = _values[1];
            }
            else if (tag.CompareTo(Constants.SCREENSIZE) == 0)
            {
                input[Constants.SCREENSIZE] = value;
            }
            else if (tag.CompareTo("DEMAND") == 0)
            {
                switch (value)
                {
                    case "Offices":
                        input[Constants.RAM] = "2GB";
                        input[Constants.CPU] = "Core M";
                        input[Constants.GPU] = "HD Graphics";
                        input[Constants.STORAGE + "_type"] = "HDD";
                        input[Constants.STORAGE + "_value"] = "500GB";
                        break;
                    case "Gaming":
                        input[Constants.RAM] = "8GB";
                        input[Constants.CPU] = "Core i7";
                        input[Constants.GPU] = "GTX";
                        input[Constants.STORAGE + "_type"] = "HDD";
                        input[Constants.STORAGE + "_value"] = "1TB";
                        break;
                    case "Graphics":
                        input[Constants.RAM] = "8GB";
                        input[Constants.CPU] = "i7";
                        input[Constants.GPU] = "GTX";
                        input[Constants.STORAGE + "_type"] = "SSD";
                        input[Constants.STORAGE + "_value"] = "512GB";
                        break;
                    case "Fashion":
                        input[Constants.WEIGHT] = "4";
                        break;
                    default:
                        break;
                }
            }
            else if(tag.CompareTo(Constants.PRICE) == 0)
            {
                switch(value)
                {
                    case "<500$":
                        input[Constants.PRICE + "_max"] = "500";
                        break;
                    case "500~700$":
                        input[Constants.PRICE + "_min"] = "500";
                        input[Constants.PRICE + "_max"] = "700";
                        break;
                    case "700~1000$":
                        input[Constants.PRICE + "_min"] = "700";
                        input[Constants.PRICE + "_max"] = "1000";
                        break;
                    case ">1000$":
                        input[Constants.PRICE + "_min"] = "1000";
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