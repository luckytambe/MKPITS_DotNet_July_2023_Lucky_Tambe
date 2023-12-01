using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Employe_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int salary = Convert.ToInt32(textBox2.Text);
            string designation = textBox3.Text;

            float hra = 0;
            float bonus = 0;
            float total = 0;

            switch (designation)
            {
                case "manager":
                    hra = salary * 0.3f;
                    bonus = salary * 0.5f;
                    break;

                case "Clerk":
                    hra = salary * 0.2f;
                    bonus = (salary * 0.3f);
                    break;

                case "peun":
                    hra = salary * 0.1f;
                    bonus = (salary * 0.2f);
                    break;
            }

            label4.Text="name : " + name;
            label5.Text = "Bonus :" + bonus;
            total = hra + salary + bonus;
            label6.Text = "Total : " + total;

        }
    }
}
