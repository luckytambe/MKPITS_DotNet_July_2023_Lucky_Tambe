using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_Assign_Employe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employe emp;
        ArrayList A = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
           emp = new Employe(Convert.ToInt32(textBox1.Text),textBox2.Text , Convert.ToInt32(textBox3.Text),textBox4.Text);
           A.Add(emp);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Employe Emp in A) 
            {
                sb.Append("Empno : " + Emp.empno + "\n");
                sb.Append("Emp Name : " + Emp.empname + "\n");
                sb.Append("Emp Salary : " + Emp.salary + "\n");
                sb.Append("Emp Designation : " + Emp.designation + "\n");
            }

            richTextBox1.Text = sb.ToString();
        }
    }
}
