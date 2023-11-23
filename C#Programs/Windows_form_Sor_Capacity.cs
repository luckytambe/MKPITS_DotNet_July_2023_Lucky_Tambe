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

namespace Windows_form_Sor_Capacity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList s = new ArrayList();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            s.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();

            label2.Text = s.Capacity.ToString();
            label3.Text = s.Count.ToString();

            StringBuilder sb = new StringBuilder();
            sb.Append(label4.Text);

            foreach( object o in s )
            {
               sb.Append(o.ToString());
            }
            label4.Text = sb.ToString();
           
        }
    }
}
