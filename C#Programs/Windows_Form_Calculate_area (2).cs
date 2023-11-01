using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_Calculate_area
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rectangle rec = new Rectangle();
            
 
            rec.width =Convert.ToInt32(textBox1.Text);
          
            rec.height=Convert.ToInt32(textBox2.Text);

            rec.total=rec.width*rec.height;

             StringBuilder sb = new StringBuilder();
            sb.Append("Rectangle is = " + rec.total);
            label3.Text=sb.ToString();
            

        }
    }
}
