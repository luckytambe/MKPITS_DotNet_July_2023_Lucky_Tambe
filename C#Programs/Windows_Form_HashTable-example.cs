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

namespace Windows_Form_HashTable_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Hashtable ha = new Hashtable();
        private void button1_Click(object sender, EventArgs e)
        {
            ha.Add(textBox1.Text, textBox2.Text);   
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            ICollection co = ha.Keys;
            foreach (string i in co)
            {
                sb.Append(" Name " + i +  "\n" + "subject : " + ha[i] );
            }
            label3.Text = sb.ToString();

           

        }
    }
}
