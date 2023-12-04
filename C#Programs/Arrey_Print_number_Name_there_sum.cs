using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//accept 5 no. and store in an array and then print sum of 5 no.

namespace Arrey_Print_number_NAde_there_sum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] num = new int[3];
        int sum = 0;
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (i < 3)
            {
                num[i] = Convert.ToInt32(textBox1.Text);
                sum = sum + num[i];
                i++;
                textBox1.Focus();
                textBox1.Clear();
                if(i == 3)
                {
                    label2.Text = "sum Of numbers = " + sum;
                }
            }           
        }
    }
}
