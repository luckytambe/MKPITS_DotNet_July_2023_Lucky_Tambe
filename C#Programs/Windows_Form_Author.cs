using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_Author
{
    
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int sr = Convert.ToInt32(textBox1.Text);
            string auth = textBox2.Text;
            string tit = textBox3.Text;
            int prc = Convert.ToInt32(textBox4.Text);

            StringBuilder sb = new StringBuilder();

            sb.Append("Serial no.: " + sr + "\n");
            sb.Append("author: " + auth + "\n");
            sb.Append("Title: " + tit + "\n");
            sb.Append("Price: " + prc + "\n");

            label5.Text = sb.ToString();
        }
    }
}
