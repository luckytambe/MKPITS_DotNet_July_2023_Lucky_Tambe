using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_Bank_Account_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person per= new Person();
            per.name=textBox1.Text;
            per.age=Convert.ToInt32(textBox2.Text);
            per.address=textBox3.Text;

            StringBuilder pp= new StringBuilder();
            pp.Append(per.name +"\n");
            pp.Append( per.age +" \n");
            pp.Append(per.address + "\n");

            label4.Text = pp.ToString();
            Console.WriteLine();
        }
    }
}
