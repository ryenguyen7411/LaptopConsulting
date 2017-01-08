using Laptop_Resuilt;
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
    public partial class demo_track : Form
    {
        public demo_track()
        {
            InitializeComponent();
            CoreSystem.init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input  = textBox1.Text;
            string[] s = input.Split(',');
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

            for( int i=0;i< output.Count;i++)
            {

                Laptop.m_laptop obj = new Laptop.m_laptop();
                    obj=(Laptop.m_laptop)output[i];
                textBox4.Text = textBox4.Text+ "\r\n"+  obj._name.ToString();

               
            }


        }
    }
}
