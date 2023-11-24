using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Hashtable As = new Hashtable();
        private void button1_Click(object sender, EventArgs e)
        {
            As.Add(textBox1.Text,textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            ICollection aa = As.Keys;

            foreach(string ob1 in aa )
            {
                sb.Append(" name : " + ob1 + "\n");
                
            }
            label3.Text = sb.ToString();

            StringBuilder sb2 = new StringBuilder();
            ICollection aa1 = As.Values;
            foreach (string ob in aa1)
            {
                sb2.Append("Age : " + ob + "\n");
            }
            label4.Text = sb2.ToString();

        }
    }
}
