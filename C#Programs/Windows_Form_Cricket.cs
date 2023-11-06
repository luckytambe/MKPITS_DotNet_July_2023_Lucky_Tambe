using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_Cricket
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cricket cric=  new Cricket();
            string name = textBox1.Text;
            int jerno = Convert.ToInt32(textBox2.Text);
            int run = Convert.ToInt32(textBox3.Text);

            StringBuilder sb = new StringBuilder();
            sb.Append(" name is : "+name + "\n");
            sb.Append("Jerno is : "+jerno + "\n");
            sb.Append(("run is :" + run + "\n"));

            richTextBox1.Text= sb.ToString();
        }
    }
}
