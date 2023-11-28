using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windos_FOrm_Employe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<int, employe> emp = new Dictionary<int, employe>();
        private void button1_Click(object sender, EventArgs e)
        {
            employe emp1 = new employe(Convert.ToInt32(textBox1.Text),textBox2.Text) ;
            emp.Add(emp1.empno , emp1 );
            textBox1.Clear();
            textBox2 .Clear();
            textBox2.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(KeyValuePair<int,employe> k in emp)
            {
                sb.Append("Empno : " + k.Key + "  EmpName : " + k.Value.name + "\n");
            }

            label3.Text = sb.ToString();    
        }
    }
}
