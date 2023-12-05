using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_form_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
      
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            label4.Text = "Name : " + name;

            if (numericUpDown1.Value > 18)
            {
                MessageBox.Show("It is applicable");
               
            }
            else
            {
                label5.Text = "age is : " + numericUpDown1.Value.ToString();
            }
            label5.Text= "Age : " + numericUpDown1.Value;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            textBox1.Clear();
            numericUpDown1.Value = 0;

        }
    }
}
