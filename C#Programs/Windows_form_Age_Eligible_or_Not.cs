using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_form_Age_Eligible_or_Not
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age;
            age= Convert.ToInt32(textBox1.Text);
            StringBuilder sb = new StringBuilder();

            if(age > 18)
            {
                sb.Append("It is Eligible");
            }
            else
            {
                sb.Append("It is not Eligible");
            }
            
            label2.Text = sb.ToString();    
        }
    }
}
