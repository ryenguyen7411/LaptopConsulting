using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Laptop_Resuilt.Pc
{
    public partial class Form_demo : Form
    {
        public Form_demo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string,string> input = new Dictionary<string, string>();
           
            string s_input = textBox1.Text;
            string[]s = s_input.Split(',');
            for(int i=0;i<s.Count();i++)
            {
                string[] k = s[i].Split(':');
                input.Add(k[0], k[1]);
            }

            //ForwardChaining(input);




        }
    }
}
