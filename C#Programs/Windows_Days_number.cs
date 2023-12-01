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

namespace Windows_Days_number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            string res;
            switch (num)
            {
                case 1:
                    res = "Monday";
                    break;
                case 2:
                    res = "Tuesday";
                    break;
                case 3:
                    res = "wednusday";
                    break;
                case 4:
                    res = "thusday";
                    break;
                case 5:
                    res = "friday";
                    break;
                case 6:
                    res = "Saturday";
                    break;
                case 7:
                    res = "Sunday";
                    break;

                default:
                    res = "invalid Day";
                    break;

            }
            label2.Text = res.ToString();
        }
    }
}
