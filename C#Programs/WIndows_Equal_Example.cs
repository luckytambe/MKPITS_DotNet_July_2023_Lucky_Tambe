using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIndows_Equal_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1,num2;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 =Convert.ToInt32(textBox2.Text);

            if(num1 == num2)
            {
                label2.Text = "It is Equal";
            }
            else
            {
                label2.Text = "Not Equal";
            }
        }
    }
}
