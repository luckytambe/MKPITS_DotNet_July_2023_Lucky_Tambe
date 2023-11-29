using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowBank;
using BankLibrary;
namespace WindowBank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void label3_Click(object sender, EventArgs e)
        {

        }
        Account a = null;
        string res = null;
        private void button1_Click(object sender, EventArgs e)
        {
            a.Accno = Convert.ToInt32(textBox1.Text);
            res = a.deposit(a.Accno, Convert.ToInt32(textBox2.Text));
            label4.Text = res;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a.Accno = Convert.ToInt32(textBox1.Text);
            res = a.withdraw(a.Accno, Convert.ToInt32(textBox2.Text));
            label4.Text = res;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "saving")
            {
                a = new saving();
            }

            else if(comboBox1.Text == "current")
            {
                a = new current();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
