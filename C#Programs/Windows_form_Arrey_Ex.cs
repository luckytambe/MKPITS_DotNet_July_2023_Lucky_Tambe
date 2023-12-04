using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_form_Arrey_Ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        string[,] al = new string[2,2];
        StringBuilder sb = new StringBuilder();
        private void button1_Click(object sender, EventArgs e)
        {
            al[0,0] =textBox1.Text;
            al[0,1]= textBox2.Text;
            al[1,0]= textBox3.Text;
            al[1,1]= textBox4.Text;

            sb.Append( " Album Name : " + al[0,0]  + " Director Name : " + al[0,1] + "\n");
            sb.Append(" Album Name : " + al[1,0] + " Director Name : " + al[1,1] + "\n");
            
            label5.Text = sb.ToString(); 
        }

        

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
