﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greater_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;

            num1=Convert.ToInt32(textBox1.Text);
            num2=Convert.ToInt32(textBox2.Text);
            num3=Convert.ToInt32(textBox3.Text);

            if ( num1 > num2  && num1 > num3 )
            {
                label4.Text = "Number One Is Greater";
            }
            else if (num2 > num3 )
            {
                label4.Text = "Number Two Is Greater";
            }
            else
            {
                label4.Text = "Number Three is Greater";   
            }

        }
    }
}
