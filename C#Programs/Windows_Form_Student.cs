using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int srno=Convert.ToInt32(textBox1.Text);
            string empame=textBox2.Text;
            string desi=textBox3.Text;
            int salary=Convert.ToInt32(textBox4.Text);

            StringBuilder sb = new StringBuilder();
            sb.Append("SRno  " + srno+"\n");
            sb.Append("empname  " + empame+"\n");
            sb.Append("Desi  " + desi+"\n");
            sb.Append("Salary  " + salary + "\n");

            richTextBox1.Text= sb.ToString();


        }
    }
}
