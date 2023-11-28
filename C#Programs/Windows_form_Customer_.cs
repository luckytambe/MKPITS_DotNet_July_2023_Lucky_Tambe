using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_form_Customer_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<int , Customer > C = new Dictionary<int , Customer >();
        private void button1_Click(object sender, EventArgs e)
        {
            Customer c1 = new Customer(Convert.ToInt32(textBox1.Text),textBox2.Text);
            C.Add(c1.id, c1);
            textBox1.Clear();   
            textBox2.Clear();   
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(KeyValuePair<int , Customer> kvp in C)
            {
                sb.Append("Id : " + kvp.Key + " Name : " + kvp.Value.name  + "\n");
            }
            label3.Text = sb.ToString();
        }
    }
}
