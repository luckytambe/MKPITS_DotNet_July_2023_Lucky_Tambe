using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Store_name_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        string[,] album = new string[1, 2];
        StringBuilder sb = new StringBuilder();
        private void button1_Click(object sender, EventArgs e)
        {
            album[0,0] = textBox1.Text;
            album[0,1] = textBox2.Text; 
            textBox1.Focus();
            textBox1.Clear();
            textBox2.Clear();

            sb.Append("Album Name : " + album[0,0]  + "\n" + " Singer Name : " + album[0,1] );
            label3.Text = sb.ToString();
        }
    }
}
