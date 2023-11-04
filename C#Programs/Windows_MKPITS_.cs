using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_MKPITS_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student stud = new Student();
            int srno= Convert.ToInt32(textBox1.Text);
            string name = textBox2.Text;
            string course= textBox3.Text;
            int fees = Convert.ToInt32(textBox4.Text);

            StringBuilder sb = new StringBuilder();
            sb.Append("Srno : " + srno + "\n");
            sb.Append("Name : "+ name+ "\n");
            sb.Append("Course : "+ course + "\n");
            sb.Append("Fees : " + fees + "\n");

            richTextBox1.Text = ToString();



        }
    }
}
