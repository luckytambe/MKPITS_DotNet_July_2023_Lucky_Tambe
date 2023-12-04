using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_form_Bonus_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int esal = Convert.ToInt32(textBox2.Text);
            float total = 0;
            float bonus = esal + 2500.00f;

            if (checkBox1.Checked)
            {
                total = bonus;
            }
            else if(checkBox2.Checked)
            {
                total = esal;
            }

            else
            {
                MessageBox.Show("Please cheak any cheakbox");
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Name: " + name);
            sb.AppendLine("Total: " + total);

            label3.Text = sb.ToString();
        }
    }
}
