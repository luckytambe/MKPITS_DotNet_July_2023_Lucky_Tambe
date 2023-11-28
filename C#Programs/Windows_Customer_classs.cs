using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Customer_classs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<int,Customer> d = new Dictionary<int,Customer >();
        private void button1_Click(object sender, EventArgs e)
        {

            Customer c1 = new Customer(Convert.ToInt32(textBox1.Text), textBox2.Text);
            Customer c2 = new Customer(Convert.ToInt32(textBox3.Text), textBox4.Text);
            d.Add(c1.id, c1);
            d.Add(c2.id, c2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach(KeyValuePair<int , Customer> c in d)
            {
                sb.Append("Key : " + c.Key + "Value : " + c.Value.name );
            }

            label5.Text = sb.ToString();
        }
    }
}
