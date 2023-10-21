using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Grade_Example
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            char ch;

            ch=Convert.ToChar(textBox1.Text);

            switch (ch)
            {
                case 'e':
                    label2.Text = "Excellent";
                    break;
                case 'v':
                    label2.Text = "Very Good";
                    break;
                case 'g':
                    label2.Text = "Good";
                    break;
                case 'a':
                    label2.Text = "Avarage";
                    break;
                case 'f':
                    label2.Text = "Fail";
                    break;

                default:
                    label2.Text = "Invalid";
                    break;
            }

        }
    }
}
