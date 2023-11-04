using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Windows_Form_Family_Age
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb= new StringBuilder();

            sb.Append("-----The Older Details Are----");

            for (int i=0; i<3; i++)
            {
          
                sb.Append("Name : " + fam[i].Name+"\n");
                sb.Append("Age : " + fam[i].age+"\n");
                sb.Append("gender :" + fam[i].gender + "\n");
            }

            label4.Text = sb.ToString();
            int high = fam[0].age;
            int flag = 0;

            for (int i=0; i<3;i++)
            {
               for(int j=0; j<3;j++)
                {
                    if (fam[i].age < fam[i].age)
                    {
                        high = fam[j].age;
                        flag = j;
                    }
                }
            }
            StringBuilder sb1 = new StringBuilder();

            sb1.Append("Name : " + fam[flag].Name + "\n");
            sb1.Append("Age : " + fam[flag].age + "\n");
            sb1.Append("Gender : " + fam[flag].gender + "\n");

            richTextBox1.Text= sb1.ToString();
            



        }
        Family[] fam = new Family[3];
        int cnt = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            fam[0]= new Family();
            fam[1]= new Family();
            fam[2]= new Family();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cnt < 3)
            {
                fam[cnt].Name=textBox1.Text;
                fam[cnt].age = Convert.ToInt32(textBox2.Text);
                fam[cnt].gender =textBox3.Text;
                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
                
                if (cnt ==3)
                {
                    textBox1.Enabled= false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    button1.Enabled = false;
                    MessageBox.Show("Check Who is older in family Click on submit");
                    button2.Enabled = true;
                }
            }
        }
    }
}
