using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generic_Windows_Form_Id_Name
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, Student> cust = new Dictionary<int,Student>();
        private void button1_Click(object sender, EventArgs e)
        {
            Student c1 = new Student(Convert.ToInt32(textBox1.Text), textBox2.Text);
            Student c2 = new Student(Convert.ToInt32(textBox3.Text), textBox4.Text);
            cust.Add(c1.Id, c1);
            cust.Add(c2.Id, c2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<int, Student> kv in cust)
            {
                sb.Append("cust id " + kv.Key + " customer name " + kv.Value.name + "\n");
            }
            label5.Text = sb.ToString();
        }

    }
}
