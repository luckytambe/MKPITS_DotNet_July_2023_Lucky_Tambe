﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_form_Print_number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int num=Convert.ToInt32(textBox1.Text);

            int i = 1;
            while (i <= num)
            {
                sb.Append(i + "\n");
                i++;
            }
            label2.Text = sb.ToString();
        }
    }
}
