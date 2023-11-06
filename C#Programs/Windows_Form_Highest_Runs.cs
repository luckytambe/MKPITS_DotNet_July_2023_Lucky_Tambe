using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_Highest_Runs
{
    public partial class Form1 : Form
    {
        Player[] play = new Player[2];
            int cnt =0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            play[0]= new Player();
            play[1]= new Player();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( cnt < 2)
            {
                play[cnt].name = textBox1.Text;
                play[cnt].runs=Convert.ToInt32(textBox2.Text);
                play[cnt].country = textBox3.Text;
                cnt++;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                

                if (cnt==2)
                {
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = true;
                    MessageBox.Show("If We Check Highest Run Then Click on Submit");

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("---- Details of player ----");
            for(int i = 0; i < 2; i++)
            {
                sb.Append("------------------");
                sb.Append("Name = " + play[cnt].name + "\n");
                sb.Append("Runs = " + play[cnt].runs + "\n");
                sb.Append("Name = " + play[cnt].country + "\n");

            }
            richTextBox1.Text = sb.ToString();

        }
    }
}
