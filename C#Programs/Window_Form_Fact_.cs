using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Window_Form_Fact_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder ab = new StringBuilder();
            int  num=Convert.ToInt32(textBox1.Text);
            int res = 1;
            for (int count =1; count <=  10; count ++)
            {
                res = num * count;
                ab.Append(num + "x" + count + "= " + res +"\n");
            }
            label2.Text = ab.ToString();
        }
    }
}
