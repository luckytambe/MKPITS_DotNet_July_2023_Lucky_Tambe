﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_Example_
{
    public partial class Solution : Form
    {
        public Solution()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name : " + textBox1.Text + "\n");
            sb.Append("Pass : " + textBox2.Text +  "\n");
            string gender = null;
            if(radioButton1.Checked )
            {
                gender = radioButton1.Text;
            }
            else if ( radioButton2.Checked )
            {
                gender = radioButton2.Text;
            }
            sb.Append("Gender : " + gender + "\n");

            if(checkBox1.Checked )
            {
                sb.Append("Course : " + checkBox1.Text + "\n");
            }
            else if( checkBox2.Checked )
            {
                sb.Append( " course : " + checkBox1.Text+ "\n");
            }            
            sb.Append("Country : " + comboBox1.Text + "\n");
            sb.Append("State : " + comboBox2.Text + "\n");
            sb.Append("city : " + comboBox3.Text + "\n");
            label8.Text = sb.ToString();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            switch (comboBox1.Text)
            {
                case "India":
                    comboBox2.Items.Add("Maharashtra");
                    comboBox2.Items.Add("jugrat");
                    break;

                case "USA":
                    comboBox2.Items.Add("Lausiana");
                    comboBox2.Items.Add("Arizona");
                    break;
             }      
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            switch (comboBox2.Text)
            {
                case "maharashtra":
                    comboBox3.Items.Add("Nagpur");
                    comboBox3.Items.Add("mumbai");
                    break;
                case "jugrat":
                    comboBox3.Items.Add("Bhopal");
                    comboBox3.Items.Add("surat");
                    break;

            }
        }
    }
}