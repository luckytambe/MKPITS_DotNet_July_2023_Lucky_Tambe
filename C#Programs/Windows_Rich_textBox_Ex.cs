using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Rich_textBox_Ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder xy = new StringBuilder();
            int num = Convert.ToInt32(textBox1.Text);
            int res = 1;
            for( int count = 1; count <=10; count++)
            {
                res = count * num;
                xy.Append(num + "x" + count + "=" + res + "\n");
            }
            richTextBox1.Text = xy.ToString();
        }    
    }
}
