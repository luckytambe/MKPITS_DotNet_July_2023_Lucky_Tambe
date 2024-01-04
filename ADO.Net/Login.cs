using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strcon = "service = LUCKY-TAMBE\\ SQLEXPRESS ; integrated Security = true ; database = SQLSERVER ";
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlCommandBuilder cb = null;


        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
