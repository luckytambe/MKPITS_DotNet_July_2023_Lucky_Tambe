using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addition_Windows_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int addition = num1 + num2;

            label3.Text = "Addition" + addition;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1=Convert.ToInt32(textBox1.Text);
            int num2=Convert.ToInt32(textBox2.Text);
            int Subtration = num1 - num2;

            label3.Text = "Subtration" + Subtration;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 =Convert.ToInt32(textBox2.Text);
            int multiplication = num1 * num2;

            label3.Text = "multiplication" + multiplication;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int Division = num1 / num2;

            label3.Text = "Division" + Division;

        }
    }
}
