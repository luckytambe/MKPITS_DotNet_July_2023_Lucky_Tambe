using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_form_calculator_P
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int prvnum = 0;
        string op;
        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "9";
            }
            else
            {
                if (op != null)
                {
                    if (textBox1.Text == "/" || textBox1.Text == "*" || textBox1.Text == "-" || textBox1.Text == "+")
                    {
                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + "9";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "9";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text + "9";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="")
            {
                textBox1.Text = "1";
            }
            else 
            {
                if (op != null)
                {
                    if(textBox1.Text == "/" || textBox1.Text == "-" || textBox1.Text == "+" || textBox1.Text == "*")
                    {
                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + "1";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "1";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text + "1";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "2";
            }
            else
            {
                if (op != null)
                {
                    if (textBox1.Text == "/" || textBox1.Text == "-" || textBox1.Text == "+" || textBox1.Text == "*")
                    {
                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + "2";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "2";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text + "2";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.Text = "3";
            }
            else
            {
                if(op != null)
                {
                    if(textBox1.Text=="/" || textBox1.Text == "*" || textBox1.Text == "-" || textBox1.Text == "+")
                    {
                        textBox1.Clear() ;
                        textBox1.Text = textBox1.Text + "3";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "3";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text + "3";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            prvnum = Convert.ToInt32(textBox1.Text);
            op = "/";
            textBox1.Text = "/";    
        }

        private void button16_Click(object sender, EventArgs e)
        {
            

        }

        private void button14_Click(object sender, EventArgs e)
        {
            float res = 0;
            switch (op)
            {
                case "/":
                    res = prvnum / Convert.ToInt32(textBox1.Text);
                    break;

                case "*":
                    res = prvnum * Convert.ToInt32(textBox1.Text);
                    break;

                case "-":
                    res = prvnum * Convert.ToInt32(textBox1.Text);
                    break;

                case "+":
                    res = prvnum * Convert.ToInt32(textBox1.Text);
                    break;
            }
            textBox1.Text = res.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "4";
            }
            else
            {
                if (op != null)
                {
                    if (textBox1.Text == "/" || textBox1.Text == "*" || textBox1.Text == "-" || textBox1.Text == "+")
                    {
                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + "4";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "4";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text + "4";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "5";
            }
            else
            {
                if (op != null)
                {
                    if (textBox1.Text == "/" || textBox1.Text == "*" || textBox1.Text == "-" || textBox1.Text == "+")
                    {
                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + "5";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "5";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text + "5";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "6";
            }
            else
            {
                if (op != null)
                {
                    if (textBox1.Text == "/" || textBox1.Text == "*" || textBox1.Text == "-" || textBox1.Text == "+")
                    {
                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + "6";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "6";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text + "6";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            prvnum = Convert.ToInt32(textBox1.Text);
            op = "+";
            textBox1.Text = "+";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "7";
            }
            else
            {
                if (op != null)
                {
                    if (textBox1.Text == "/" || textBox1.Text == "*" || textBox1.Text == "-" || textBox1.Text == "+")
                    {
                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + "7";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "7";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text + "7";
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "8";
            }
            else
            {
                if (op != null)
                {
                    if (textBox1.Text == "/" || textBox1.Text == "*" || textBox1.Text == "-" || textBox1.Text == "+")
                    {
                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + "8";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "8";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text + "8";
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            prvnum = Convert.ToInt32(textBox1.Text);
            op = "-";
            textBox1.Text = "-";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
         
        }
    }
}
