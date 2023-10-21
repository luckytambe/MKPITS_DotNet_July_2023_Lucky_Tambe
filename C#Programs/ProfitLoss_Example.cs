using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfitLoss_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sp, cp;
            int profit = 0;

           sp=Convert.ToInt32(textBox1.Text);
           cp=Convert.ToInt32(textBox2.Text);

            
            if ( sp > cp )
            {
                profit = sp - cp;
                label3.Text = "Profit is : " + profit;
            }
            else if (sp < cp)
            {
                profit = cp - sp;
                label3.Text = "Loss is : " + profit;
            }
            else
            {
                label3.Text = "No profit No loss : ";
            }
            

        }
    }
}
