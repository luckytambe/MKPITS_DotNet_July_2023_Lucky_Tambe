using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_form_Operator_Ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            string op = textBox3.Text;
            int res = 0;

            switch (op)
            {
                case "+":
                 res = num1 + num2;
                   break;

                case "-":
                res = num1 - num2;
                    break;

                case "*":
                    res = num1 * num2;
                    break;

                case "/":
                    res = num1 / num2;
                    break;
            }

            label4.Text = res.ToString();


        }
    }
}
