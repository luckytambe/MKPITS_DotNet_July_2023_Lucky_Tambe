using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList ar = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(textBox1.Text);

            ar.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("capacity" + ar.Capacity);
            MessageBox.Show("Count " + ar.Count);
            StringBuilder sb = new StringBuilder();
            foreach ( object obj in ar )
            {
                sb.Append("numbers : " + obj.ToString() + "\n");
            }
            label2.Text = sb.ToString();
        }
    }
}
