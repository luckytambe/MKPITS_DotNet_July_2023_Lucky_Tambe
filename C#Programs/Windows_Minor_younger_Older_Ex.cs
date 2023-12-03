using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Minor_younger_Older_Ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt32(textBox1.Text);
            StringBuilder sb = new StringBuilder(); 

            if (num < 18)
            {
                sb.Append("It is minor");
            }
            else if ( num < 30)
            {
                sb.Append("It is younger");
            }
            else
            {
                sb.Append("It is Old");
            }
            label2.Text = sb.ToString();
        }
    }
}
