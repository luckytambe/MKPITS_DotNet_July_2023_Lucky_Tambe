using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_Bank_Person_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            person per= new person();
            per.name = textBox1.Text;
            per.age=Convert.ToInt32(textBox2.Text);
            per.address = textBox3.Text;

            StringBuilder sb = new StringBuilder();
            sb.Append(per.name+"\n");
            sb.Append(per.age+"\n");
            sb.Append(per.address + "\n");

            label4.Text= sb.ToString();

 
        }
    }
}
