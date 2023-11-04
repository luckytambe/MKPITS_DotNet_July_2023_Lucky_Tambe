using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_family
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Family fam= new Family();
            int srno =Convert.ToInt32(textBox1.Text);
            string name= textBox2.Text;
            string gender= textBox3.Text;
            string designation = textBox4.Text; 

            StringBuilder sb = new StringBuilder();
            sb.Append("Srno : " + srno + "\n");
            sb.Append("Name : " + name + "\n");
            sb.Append("gender : "+ gender + "\n");
            sb.Append("designation : "+ designation+"\n");

            label5.Text=sb.ToString();
        }
    }
}
