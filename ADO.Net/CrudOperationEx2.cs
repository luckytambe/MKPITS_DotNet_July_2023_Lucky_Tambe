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

namespace Example2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Conss = "server = LUCKY-TAMBE\\SQLEXPRESS; integrated security = true ; database = FormAssign";
        string gender;
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Conss);

            try
            {
                 if (radioButton1.Checked == true)
                    {
                        gender = "Male";
                    }
                    if (radioButton2.Checked == true)
                    {
                        gender = "Female";
                    }
                con.Open();             
                string constr = "insert into Form values ('" + textBox1.Text + "' , '" +
                    textBox2.Text + "' , '" + textBox3.Text + "' , '" +
                    textBox4.Text + "' , '" + gender + "' , '"+ comboBox1.SelectedItem+"' )";             

                SqlCommand cmd = new SqlCommand(constr ,con);
                cmd.ExecuteNonQuery();
                MessageBox.Show ("Record successFully Inserted".ToString());
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Focus();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }

          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(Conss);
            try
            {
                con.Open();
                MessageBox.Show("Connected-Server SuccessFully");
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Conss);

            try
            {
                if (radioButton1.Checked == true)
                {
                    gender = "Male";
                }
                if (radioButton2.Checked == true)
                {
                    gender = "Female";
                }
                con.Open();
                string constr = "update Form set  EmpName = '" +  textBox2.Text + "' EmpDesig = '" + textBox3.Text + "' Salary = '" +  textBox4.Text + "' , '" + gender + "' , '" + comboBox1.SelectedItem + "'EmployeID = '" + textBox1.Text + "' )";

                SqlCommand cmd = new SqlCommand(constr, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record successFully Inserted".ToString());
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Focus();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Conss);

            try
            {
                if (radioButton1.Checked == true)
                {
                    gender = "Male";
                }
                if (radioButton2.Checked == true)
                {
                    gender = "Female";
                }
                con.Open();
                string constr = "select * from Form where EmpName = '" + textBox2.Text + "'";

                SqlCommand cmd = new SqlCommand(constr, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record successFully Inserted".ToString());
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Conss);

            try
            {
                if (radioButton1.Checked == true)
                {
                    gender = "Male";
                }
                if (radioButton2.Checked == true)
                {
                    gender = "Female";
                }
                con.Open();
                string constr = "delete from Form where EmployeID = '" + textBox1.Text + "' ";
                SqlCommand cmd = new SqlCommand(constr, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record successFully Inserted".ToString());
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Focus();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
