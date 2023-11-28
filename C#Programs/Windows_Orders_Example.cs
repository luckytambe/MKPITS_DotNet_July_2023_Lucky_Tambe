using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Orders_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<int , Orders > or = new Dictionary<int, Orders> ();
        Orders ord = null;
        private void button1_Click(object sender, EventArgs e)
        {
            ord = new Orders(Convert.ToInt32(textBox1.Text), textBox2.Text , Convert.ToInt32(textBox3.Text),Convert.ToInt32(textBox4.Text));
            or.Add(Convert.ToInt32(textBox1.Text), ord);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
            MessageBox.Show("customer objects added to dictionary colletion");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int total = 0;
            {
                StringBuilder sb = new StringBuilder();

                foreach (KeyValuePair<int, Orders> k in or)
                {
                    int amount = k.Value.rate + k.Value.Qty;
                    total = total + amount;
                    sb.Append("Keys : " + k.Key + " Name : " + k.Value.name + " Rate : " + k.Value.rate + " Quantity : " + k.Value.Qty + "total Amount = " + amount + "\n");

                }
                richTextBox1.Text = sb.ToString();

                MessageBox.Show("Total Amount is : " + total);
            }

        }
    }
}
