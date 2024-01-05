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

        String Connection = "Server = LUCKY-TAMBE\\SQLEXPRESS ; integrated Security = True ; Database = SQLSERVER ";
        SqlDataAdapter Sqlda;
        DataSet dataSet = new DataSet();
        SqlCommandBuilder cb;
        public Form1()
        {
            InitializeComponent();
            Sqlda = new SqlDataAdapter("Select * from Employe", Connection);
            cb = new SqlCommandBuilder(Sqlda);
            dataSet = new DataSet();
            Sqlda.Fill(dataSet,"Empl");
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            textBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            textBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            textBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            textBox7.Text = dataGridView1[6, e.RowIndex].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            DataRow dr = dataSet.Tables["Empl"].NewRow();
            
            dr[0] = textBox1.Text;
            dr[1] = textBox2.Text;
            dr[2] = textBox3.Text;
            dr[3] = Convert.ToInt32(textBox4.Text);
            dr[4] = textBox5.Text;
            dr[5] = textBox6.Text;
            dr[6] = Convert.ToInt32(textBox7.Text);
          
            dataSet.Tables["Empl"].Rows.Add(dr);
           
            Sqlda.Update(dataSet.Tables["Empl"]);
            MessageBox.Show("Data Successfully Inserted..");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox1.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataSet.Tables["Empl"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in dataSet.Tables["Empl"].Rows)
            {
                if (dr[0].ToString() == textBox1.Text)
                {
                    try
                    {
                        dr[0] = textBox1.Text;
                        dr[1] = textBox2.Text;
                        dr[2] = textBox3.Text;
                        dr[3] = Convert.ToInt16(textBox4.Text);
                        dr[4] = textBox5.Text;
                        dr[5] = textBox6.Text;
                        dr[6] = Convert.ToInt32(textBox7.Text);
                        Sqlda.Update(dataSet.Tables["Empl"]);
                        MessageBox.Show("Data Successfully Updated..");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                }
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            foreach (DataRow dr in dataSet.Tables["Empl"].Rows)
            {
                if (dr[0].ToString() == textBox1.Text)
                {
                    try
                    {
                        dr.Delete();
                       
                        Sqlda.Update(dataSet.Tables["Empl"]);
                        dataSet.Tables["Empl"].AcceptChanges();
                        MessageBox.Show("Data Successfully Deleted..");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Employe_ID = comboBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
            comboBox1.DataSource = dataSet.Tables["Empl"];
            comboBox1.DisplayMember = "Employe_ID";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            textBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            textBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            textBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            textBox7.Text = dataGridView1[6, e.RowIndex].Value.ToString();

        }
    }
}
