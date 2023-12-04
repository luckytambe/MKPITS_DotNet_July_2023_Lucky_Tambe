using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Manager_clerk_peon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int sal = Convert.ToInt32(textBox2.Text);
            string designation = comboBox1.Text;

            float bonus = 0.0f;
            float totalsal = 0.0f;

            switch(designation)
            {
                case "Manager":
                    bonus = sal + 0.40f;
                    break;
                case "Clerk":
                    bonus = sal + 0.30f;
                    break;
                case "Peon":
                    bonus = sal + 0.20f;
                    break;
            }

            totalsal = sal + bonus;

            if(checkBox1.Checked)
            {
                label4.Text = "bonus" + bonus;
            }
            if(checkBox2.Checked)
            {
                label4.Text = "Total_salary" + totalsal;
            }
        }
        



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
