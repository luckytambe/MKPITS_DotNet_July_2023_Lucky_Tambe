using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void admissionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Admission a = new Admission();
            a.MdiParent = this;
            a.Show();
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact c = new Contact();
            c.MdiParent = this;
            c.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Admission a = new Admission();
            a.MdiParent = this;
            a.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Contact C = new Contact();
            C.MdiParent = this;
            C.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Admission a = new Admission();
            a.MdiParent = this;
            a.Show();


            if (textBox1.Text == "admin"  && textBox2.Text == "admin")
            {
                MessageBox.Show("Login successfully");
            }
            else
            {
                MessageBox.Show("Invalid Crediantial");
            }

            fileToolStripMenuItem.Enabled = true;
            toolStripButton1.Enabled = true;
            toolStripButton3.Enabled = true;


        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }
    }
}
