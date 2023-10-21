using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equilateral_isosceles_or_Scalene__
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

        private void button1_Click(object sender, EventArgs e)
        {
            int SideA, SideB, SideC;

            SideA = Convert.ToInt32(textBox1.Text);
            SideB = Convert.ToInt32(textBox2.Text);
            SideC = Convert.ToInt32(textBox3.Text);

            if (SideA == SideB  && SideB == SideC &&  SideC == SideA )
            {
                label4.Text = "It is Equilateral";
            }
            else if (SideA == SideB || SideB == SideC || SideB == SideC)
            {
                label4.Text = "It is Isosceles";
            }
            else
            {
                label4.Text = "It is Scalene";
            }

        }
    }
}
