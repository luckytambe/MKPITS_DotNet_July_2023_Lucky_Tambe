using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_Employe_Highest_Salery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Employe[] emp = new Employe[3];
        int cnt = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if(cnt < 3 )
            {
                emp[cnt].Id = Convert.ToInt32(textBox1.Text);
                emp[cnt].Name=textBox2.Text;
                emp[cnt].salary= Convert.ToDouble(textBox3.Text);
                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();

                if (cnt == 3)
                {
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled= false;
                    button1.Enabled = false;
                    MessageBox.Show("Click On Submit button");
                    button2.Enabled = true;
                }
                    


            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            emp[0]= new Employe();
            emp[1]= new Employe();
            emp[2]= new Employe();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();

            for ( int i =0; i< 3; i++ )

            {
                Console.WriteLine("--------------------------------------");
                sb.Append("Id is  " + emp[i].Id+ "\n");
                sb.Append("name is  " + emp[i].Name + "\n");
                sb.Append("Salary is  " + emp[i].salary + "\n");
                Console.WriteLine("--------------------------------------");
            }

            label4.Text= sb.ToString();
            //code to find highest salary

            double high = emp[0].salary;
            int founded = 0;


            for( int i = 1; i< 3; i++ )
            {
                
                   if (high < emp[i].salary)
                { 
                        high = emp[i].salary;
                        founded = i;

                }
                
            }

            StringBuilder sb1 = new StringBuilder();

            sb1.Append(" Employe Id : " + emp[founded].Id+ "\n");
            sb1.Append(" Employe Name : " +emp[founded].Name + "\n");
            sb1.Append(" Employe Salary : " + emp[founded].salary+ "\n");

            label5.Text= sb1.ToString();
        }
    }
}
