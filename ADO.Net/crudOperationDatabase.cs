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


namespace ADO.FirstForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Cons = "server = LUCKY-TAMBE\\SQLEXPRESS;integrated security = true ; database = ADOConnection";
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            SqlConnection con = new  SqlConnection ( Cons );
            try
            {
                con.Open ();
                MessageBox.Show("Connection Succesfully");
                con.Close ();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection( Cons );
            try
            {
                con.Open();
                string query = "Delete from Ado where UserName = '" + textBox1.Text + "' and  PassWords = '" + textBox2.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                 cmd.ExecuteNonQuery ();
                label3.Text = "Deleting SuccessFully".ToString();
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show (ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cons = new SqlConnection ( Cons);
            try
            {
                cons.Open();
                string query = " select * from Ado where UserName = '" + textBox1.Text + "'" ;
                SqlCommand cmd = new SqlCommand(query, cons);
                cmd.ExecuteNonQuery ();
                label3.Text = " Search SucessFully ".ToString();
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                cons.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection ( Cons );

            try
            {
                con.Open();
                string query = "insert into Ado values ('" + textBox1.Text + "' , '" + textBox2.Text +"')";
                SqlCommand cmd = new SqlCommand (query,con);
                cmd.ExecuteNonQuery();
                label3.Text= "Deta Inserted Successfully".ToString();
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

            }
            catch( Exception ex)
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
            SqlConnection con = new SqlConnection ( Cons );
            try
            {
                con.Open ();
                string query = "Update Ado set PassWords = '" + textBox2.Text + "' where UserName = '" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(query,con);
                cmd.ExecuteNonQuery();
                label3.Text = "Pass Update SuccessFully".ToString ();
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            catch (Exception ex )
            {
                MessageBox.Show (ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
