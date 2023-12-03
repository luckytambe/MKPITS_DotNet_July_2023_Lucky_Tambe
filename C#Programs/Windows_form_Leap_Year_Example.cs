using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_form_Leap_Year_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int num = Convert.ToInt32(textBox1.Text);
            

            if (num %4 == 0)
            {
                sb.Append("Leap Year");
            }
            else
            {
                sb.Append("Not");
            }
            label2.Text= sb.ToString();

        }
    }
}
