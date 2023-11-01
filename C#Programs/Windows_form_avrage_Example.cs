using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_form_avrage_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Subject sub = new Subject();

            sub.name = Convert.ToString(textBox5.Text);
            sub.rollno = Convert.ToInt32(textBox4.Text);
            sub.biology = Convert.ToInt32(textBox1.Text);
            sub.physics = Convert.ToInt32(textBox2.Text);
            sub.maths   = Convert.ToInt32(textBox3.Text);


            sub.total = sub.physics + sub.maths + sub.maths;
            sub.Avrage = sub.total / 300.0f;

            StringBuilder sb = new StringBuilder();

            sb.Append("Name = " + sub.name+"\n");

            sb.Append("RollNo = " +sub. rollno + "\n");

            sb.Append(" Total marks = " + sub.total +"\n");
            
            sb.Append("Avarage = " + sub.Avrage );

            label4.Text= sb.ToString();
       


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
