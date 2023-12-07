using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mcq_Question
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int flag = 0;

            if(radioButton2.Checked )
            {
                flag++;
            }
            else
            {
                
            }

            if(radioButton7.Checked ) 
            { 
                flag++;
            }
            else
            {
                
            }

            if(radioButton9.Checked )
            {
                flag++;
            }
            else
            {
                
            }
            sb.Append("Total Marks Is : " + flag);
            label1.Text = sb.ToString();
            

        }
    }
}
