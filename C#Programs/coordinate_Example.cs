﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coordinate_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);

            if (num1 > 0 && num2 > 0)
            {
                label3.Text = " It is First Quadrant";
            }
            else if (num1 < 0 && num2 > 0)
            {
                label3.Text = "It is Second Quadrant ";
            }
            else if (num1 < 0 && num2 < 0)
            {
                label3.Text = "It is third Quadrant ";
            }
            else if (num1 > 0 && num2 < 0)
            {
                label3.Text = "It is Fourth Quadrant";
            }
            else
            {
                label3.Text = "Invalid";
            }
        }
    }
}
