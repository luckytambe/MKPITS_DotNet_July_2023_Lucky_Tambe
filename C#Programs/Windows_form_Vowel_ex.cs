using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_form_Vowel_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
            char ch = Convert.ToChar(textBox1.Text);
            string res;
            switch(ch)
            {
                case 'a':
                    res = "vowel";
                    break;
                case 'e':
                    res = "vowel";
                    break;
                case 'i':
                    res = "vowel";
                    break;
                case 'o':
                    res = "vowel";
                    break;
                case 'u':
                    res = "vowel";
                    break;

                default:
                    res = "not vowel";
                    break;

            }
            label2.Text = res.ToString();
        }
    }
}
