using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_Operation_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string str = "server = LUCKY-TAMBE\\SQLEXPRESS ; integrated security = true ; database = FromAssign";
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        public void cleartext()
        {
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            comboBox1.Text = "";
            dateTimePicker1.Value = DateTime.Now;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string G = null;
            string H = null;

            if (radioButton1.Checked)
            {
                G = "Male";
            }
            if (radioButton2.Checked)
            {
                G = "Female";
            }
            if (checkBox1.Checked)
            {
                H = "Cricket";
            }
            if (checkBox2.Checked)
            {
                if (H != null)
                    H = H + " " + "FootBall";
                else
                    H = "FootBall";
            }
            Student s = new Student();
            string Result = s.InsertStudent(Convert.ToInt32(textBox1.Text), textBox2.Text, G, H, comboBox1.Text, dateTimePicker1.Value.ToShortDateString());
            MessageBox.Show(Result);

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string G = null;
            string H = null;

            if (radioButton1.Checked)
            {
                G = "Male";
            }
            if (radioButton2.Checked)
            {
                G = "Female";
            }

            if (checkBox1.Checked)
            {
                H = "Cricket";
            }
            if (checkBox2.Checked)
            {
                if (H != null)
                    H = H + " " + "FootBall";
                else
                    H = "FootBall";
            }
            Student S = new Student();
            string Result = S.InsertStudent(Convert.ToInt32(textBox1.Text), textBox2.Text, G, H, comboBox1.Text, dateTimePicker1.Value.ToShortDateString());
            MessageBox.Show(Result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student S = new Student();

            string result = S.DeleteStudent (Convert.ToInt32(textBox1.Text), textBox2.Text);

            label7.Text = result;
            cleartext();
            
        }
    }
    
}
