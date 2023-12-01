using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_for_Two_number_Example
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
        int number1, number2;
        int res = 0;

        private void button2_Click(object sender, EventArgs e)
        {
             number1 = Convert.ToInt32(textBox1.Text);
             number2 = Convert.ToInt32(textBox2.Text);
             res = number1 - number2;

            label3.Text = "Subtraction : " + res;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToInt32(textBox1.Text);
            number2 = Convert.ToInt32(textBox2.Text);
            res = number1 * number2;

            label3.Text = "multiplication : " + res;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToInt32(textBox1.Text);
            number2 = Convert.ToInt32(textBox2.Text);
            res = number1 + number2;

            label3.Text = "Division : " + res;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            number1 = Convert.ToInt32(textBox1.Text);
            number2 = Convert.ToInt32(textBox2.Text);
            res = number1 + number2;

            label3.Text = "Addition : " + res;

        }
    }
}
