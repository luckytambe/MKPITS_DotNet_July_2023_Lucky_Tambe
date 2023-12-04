using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_form_Multiple_option
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bal = 1000;
            
            int acno = Convert.ToInt32(textBox1.Text);
            int amt = Convert.ToInt32(textBox2.Text);
            
            if(radioButton1.Checked)
            {
                bal = bal + amt;
            }
            else if(radioButton2.Checked)
            {
                bal = bal - amt;
            }
            
            label3.Text = bal.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
