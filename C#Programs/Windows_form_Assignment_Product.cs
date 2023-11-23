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

namespace Windows_form_Assignment_Product
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Product p;
        ArrayList ar = new ArrayList();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            p  = new Product (Convert.ToInt32(textBox1.Text),textBox2.Text,Convert.ToInt32(textBox3.Text));
            ar.Add(p);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder ab = new StringBuilder();

            foreach(Product p in ar)
            {
                ab.Append("Product Id " + p.id +"\n");
                ab.Append("Product Name " + p.name +"\n");
                ab.Append("Product price " + p.price + "\n");
                
            }

            label4.Text = ab.ToString();
        }
    }
}
