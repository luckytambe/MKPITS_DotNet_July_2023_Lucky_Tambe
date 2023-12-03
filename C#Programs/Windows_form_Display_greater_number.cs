using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_form_Display_greater_number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;

            num1= Convert.ToInt32(textBox1.Text);
            num2= Convert.ToInt32(textBox2.Text);
            num3= Convert.ToInt32(textBox3.Text);

            StringBuilder sb = new StringBuilder();

            if(num1 > num2)
            {
                sb.Append("Number1 is greater then Number2 and Number3");
            }
            else if(num2 > num3)
            {
                sb.Append("number2 is greater then Number1 and Number3");
            }
            else
            {
                sb.Append("Number3 is greater then Number2 And Number1");
            }
            label4.Text = sb.ToString();
        }
    }
}
