using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_Library_Book_Author
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Library[] book = new Library[3];
        int cnt = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            book[0]=new Library();
            book[1]=new Library();
            book[2]=new Library();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cnt <3)
            {
                book[cnt].title = textBox1.Text;
                book[cnt].author = textBox2.Text;
                if(checkBox1.Checked)
                {
                    checkBox1 .Checked = true;
                }
                cnt++;

                button1.Enabled = false;
                textBox2.Enabled = false;
                textBox1.Enabled=false;
                button2.Enabled = true;
                MessageBox.Show("Now Click on Availabe");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(); 

            for( int i = 0; i < 3; i++)
            {
                if (book[i].Available==true)
                {
                    sb.Append("Title " + book[i].title + "\n");
                    sb.Append("Author "+ book[i].author + "\n");
                }
                label3.Text = sb.ToString();
            }
        }
    }
}
