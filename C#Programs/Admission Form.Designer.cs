using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mdi_Form_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Regitration_Form frm = new Regitration_Form();
            frm.MdiParent = this;
            frm.Show();
        }

        private void admissionFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admission_Form ad = new Admission_Form();
            ad.MdiParent = this;
            ad.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Regitration_Form r = new Regitration_Form();
            r.MdiParent= this;
            r.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Admission_Form f = new Admission_Form();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SignoutForm sign = new SignoutForm();
            sign.MdiParent = this;
            sign.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admission_Form form = new Admission_Form();
            form.MdiParent = this;
            form.Show();

            if ( textBox1.Text == "admin" && textBox2 .Text == "admin")
            {
                MessageBox.Show("Login Successfully");
                filrToolStripMenuItem.Enabled = true;
                toolStripButton1.Enabled = true;
                toolStripButton2 .Enabled = true;
                toolStripButton3.Enabled = true;
                panel1.Hide();


            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignoutForm s = new SignoutForm();
            s.MdiParent = this;
            s.Show();
            panel1.Hide();
         
        }

        private void eyebuttonshow_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
            eyebuttonhide.Visible = true;
            eyebuttonshow.Visible = false;
            eyebuttonhide.Focus();

        }

        private void eyebuttonhide_Click(object sender, EventArgs e)
        {
            textBox2 .UseSystemPasswordChar = true;
            eyebuttonhide.Visible = false;
            eyebuttonshow.Visible = true;
            eyebuttonshow.Focus();
        }
    }
}
