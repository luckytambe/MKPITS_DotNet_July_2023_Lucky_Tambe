using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Geometrical_Shape_Example
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int l, b;
            float area = 0;

            l=Convert.ToInt32(textBox1.Text);
            b= Convert.ToInt32(textBox2.Text);

            area = l * b;
            label5.Text = "Area is = " + area;

            
             

                
             


        }
    }
}
