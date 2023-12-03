using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_form_Bank_Ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 , num2 , num3 ;
            int total = 0;
            float per = 0;

            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);  
            num3 = Convert.ToInt32(textBox3.Text);

            total =  num1 + num2 + num3;
            label4.Text = "total Marks : " + total;

            per = (total * 300.0f )/ 100.0f ;
            label5.Text = "Percentage : " + per;

            if(per > 75)
            {
                label6.Text = "Topper";
            }
            else if (per < 55)
            {
                label6.Text = "Pass";
            }
            else
            {
                label6.Text = "Fail";
            }
        }
    }
}
