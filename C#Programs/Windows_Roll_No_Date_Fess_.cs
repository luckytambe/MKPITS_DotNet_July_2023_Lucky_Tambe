using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Roll_No_Date_Fess_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        Student[] stud = new Student[10];
        int cnt = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

            stud[0] =new Student();
            stud[1] = new Student();
            stud[2] = new Student();
            stud[3] = new Student();
            stud[4] = new Student();
            stud[5] = new Student();
            stud[6] = new Student();
            stud[7] = new Student();
            stud[8] = new Student();
            stud[9] = new Student();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cnt < 10)
            {
                stud[cnt].rollno = Convert.ToInt32(textBox1.Text);
                stud[cnt].date = textBox2.Text;
                stud[cnt].name = textBox3.Text;
                stud[cnt].fees = Convert.ToInt32(textBox4.Text);

                cnt++;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Focus();


                if (cnt == 10)
                {
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = true;
                    MessageBox.Show("Now Click On Submit Button ");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 10; i++)
            {
                sb.Append("Rollno : " + stud[i].rollno + "\n");
                sb.Append("Date : " + stud[i].date + "\n");
                sb.Append("Name : " + stud[i].name + "\n");
                sb.Append("fees : " + stud[i].fees + "\n");

            }

            richTextBox1.Text=sb.ToString();

            int high = stud[0].fees;
            int res = 0;
            for (int i = 1; i < 10; i++)
            {
                if( high < stud[i].fees )
                {
                    high = stud[i].fees;
                    res = i;
                }
            }

            StringBuilder sb2 = new StringBuilder();
            sb2.Append("---DETAILS OF STUDENTS--- ");

            sb2.Append("Rollno : " + stud[res].rollno + "\n");
            sb2.Append("Date : " + stud[res].date + "\n");
            sb2.Append("Name : " + stud[res].name + "\n");
            sb2.Append("fees : " + stud[res].fees + "\n");

            label5.Text = sb2.ToString();

        }
    }
}


                


