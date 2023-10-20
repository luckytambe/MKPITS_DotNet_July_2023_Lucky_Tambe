using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Height_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cm;
            cm=Convert.ToInt32(textBox1.Text);

            if (cm > 135)
            {
                label2.Text = "Dwarf";
            }
            else if (cm > 170 && cm < 200)
            {
                label2.Text = "Medium";
            }
            else
            {
                label2.Text = "Tall";
            }
        }
    }
}
