using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generic_dishnary_windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string,string> la = new Dictionary<string, string>();
        private void button1_Click(object sender, EventArgs e)
        {

            la.Add(textBox1.Text, textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            List<string> keys = new List<string>(la.Keys);
            foreach (string key in keys)
            {
                sb.Append("keys in dictionay " + key + "\n");
            }
            label3.Text = sb.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            List<string> keys = new List<string>(la.Values);
            foreach (string key in keys)
            {
                sb.Append("values in dictionay " + key + "\n");
            }
            label4.Text = sb.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<string, string> kvp in la)
            {
                sb.Append("key+value : " + kvp.Key  + kvp.Value + "\n");
            }
            label4.Text = sb.ToString();

        }
    }
}
