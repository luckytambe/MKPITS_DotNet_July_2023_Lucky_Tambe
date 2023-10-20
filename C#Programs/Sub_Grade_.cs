using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sub_Grade_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int phy, che, maths, total = 0;
            float per = 0;
            string grade = null;

            phy=Convert.ToInt32(textBox1.Text);
            che = Convert.ToInt32(textBox2.Text);
            maths= Convert.ToInt32(textBox3.Text);

            total = phy + che + maths;
            per = (total / 300.0f) * 100.0f;

            label4.Text = "Total Marks" + total;
            label5.Text = "per" + per;

            if  (per >= 75)
            {
                grade = "Grade A";
            }
            else if (per > 60 && per < 75 )
            {
                grade = "grade B";
            }
            else if ( per > 40 && per <= 60)
            {
                grade = "grade C";
            }
            else
            {
                grade = "Fail";
            }
          
            label6.Text = "grade" + grade;
            
        }
    }
}
