using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trangle_Is_Not_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int SideA, SideB, SideC;

            SideA = Convert.ToInt32(textBox1.Text);
            SideB = Convert.ToInt32(textBox2.Text);
            SideC = Convert.ToInt32(textBox3.Text);

            if(SideA== SideB && SideB==SideC && SideA==SideC)
            {
                label4.Text = "It is trangle";
            }
            else
            {
                label4.Text = " Not trangle";
            }
        }
    }
}
