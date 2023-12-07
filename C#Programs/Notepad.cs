using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {


            StringBuilder sb = new StringBuilder();

            sb.Append("Name : " + textBox1.Text + "\n");
            sb.Append("Email : " + textBox2.Text + "\n");
            sb.Append("Phone : " + textBox3.Text + "\n");

            if (radioButton1.Checked)
            {
                sb.Append("Gender :" + radioButton1.Text + "\n");
            }
            else
            {
                sb.Append("Gender:" + radioButton2.Text + "\n");
            }

            

            if (radioButton3.Checked)
            {
                sb.Append("Course " + radioButton3.Text + "\n");
            }
            else 
            {
                sb.Append("Course " + radioButton4.Text + "\n");
            }
            

            richTextBox1.Text = sb.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
