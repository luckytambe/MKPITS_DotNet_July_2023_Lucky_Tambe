﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vowel_Or_not_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char ch;
            ch = Convert.ToChar(textBox1.Text);
            
            if (ch == 'a'|| ch == 'e' || ch == 'i' ||  ch == 'o' || ch == 'u')
            {
                label2.Text = "It is Vowel";
            }
            else
            {
                label2.Text = "Not Vowel";
            }
        }
    }
}
