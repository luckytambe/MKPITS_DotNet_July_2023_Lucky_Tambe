using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form_properties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("UserName : " + textBox1.Text + "\n");
            sb.Append("PassWord : " + textBox2.Text + "\n");

            string gender = null;
            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                gender = radioButton2.Text;
            }
            sb.Append("Gender : " + gender + "\n");

            if( checkBox1.Checked )
            {
                sb.Append ("course Join : " + checkBox1.Text + "\n");
            }
            else if(checkBox2.Checked )
            {
                sb.Append("course Join : " + checkBox2.Text + "\n");
            }

            sb.Append("Country : " + comboBox1.Text + "\n");
            sb.Append("State :" + comboBox2.Text + "\n");
            sb.Append("city : " + comboBox3.Text+ "\n");
            label6.Text = sb.ToString();



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";

            switch(comboBox1.Text)
            {
                case "India":
                   comboBox2.Items.Add("Maharashtra");
                    comboBox2.Items.Add("Madhya pradesh");
                    comboBox2.Items.Add("gujrat");
                   
                    break;
                case "USA":
                    comboBox2.Items.Add("Lousiana");
                    comboBox2.Items.Add("New York");
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();

            switch(comboBox2.Text)
            {
                case "Maharashtra":
                    comboBox3.Items.Add("Nagpur");
                    comboBox3.Items.Add("Wardha");
                    comboBox3.Items.Add("Kamthee");
                    break;
                case "Madhya pradesh":
                    comboBox3.Items.Add("indor");
                    comboBox3.Items.Add("bhopal");
                    comboBox3.Items.Add("jaipur");
                    break;
                case "gujrat":
                    comboBox3.Items.Add("Ahmedabad");
                    comboBox3.Items.Add("surat");
                    comboBox3.Items.Add("Vadodara");
                    break;
            }
        }
    }
}
