using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Shorted_List_Windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SortedList s = new SortedList();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            s.Add(textBox1.Text,textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            ICollection val= s.Values;

            foreach(string o in val)
            {
                sb.Append(" name "  + o + "\n");
            }
            label3.Text = sb.ToString();


            StringBuilder sb2 = new StringBuilder();
            ICollection key = s.Keys;
            foreach (string o in key)
            {
                sb2.Append(" Age  " + o + "\n");
            }
            label4.Text = sb2.ToString();

        }
    }
}
