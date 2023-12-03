using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_Prime_number_Or_not
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox1.Text);
            StringBuilder sb = new StringBuilder(); 
            if(number%2!=0)
            {
                sb.Append("Prime");
            }
            else
            {
                sb.Append("not Prime");
            }
            label2.Text = sb.ToString();
        }
    }
}
