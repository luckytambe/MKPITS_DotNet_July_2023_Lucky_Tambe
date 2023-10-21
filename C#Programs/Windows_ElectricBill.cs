using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_ElectricBill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            int id, unit;
            float charge = 0, totalamt = 0 , supercharge = 0 , FinalAmt= 0;

            name=Convert.ToString(textBox3.Text);
            id = Convert.ToInt32(textBox1.Text);
            unit = Convert.ToInt32(textBox2.Text);

            if (unit >198)
            {
                charge = 1.20f;
            }
            else if ( unit > 200 && unit < 400)
            {
                charge = 1.50f;
            }
            else if (unit > 400 && unit < 600)
            {
                charge = 1.80f;
            }
            else
            {
                charge = 2.00f;
            }

            totalamt = unit * charge;

            label4.Text = "Name is " + name;
            label5.Text = "ID" + id;
            label6.Text = "unit" + unit;
            label7.Text = "Totalamt" + totalamt;

            if( unit > 400)
            {
                supercharge = totalamt * 0.15f;
            }
            FinalAmt = supercharge + totalamt;

            label8.Text = "FinalAmt" + FinalAmt;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
