using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_form_Age_PubliCation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string age = dateTimePicker1.Text;
            MessageBox.Show("Date Of Birth :" + age);

            int yr = dateTimePicker1.Value.Year;
            MessageBox.Show("Year Is :" + yr);

            int cyr = DateTime.Now.Year;
            MessageBox.Show("Current Year Is :" + cyr);

            

            int diff = cyr - Convert.ToInt32(yr);
            MessageBox.Show("your age is :" + diff);

            label2.Text = "Date Of Birth "+ age.ToString();
            label3.Text = "Year Is :" + yr.ToString();
            label4.Text = "Current Year Is :" + cyr.ToString();
            label5.Text = " your age is " + diff.ToString();



        }
    }
}
