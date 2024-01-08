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

namespace Fendal_Windows_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Connection = "Server = LUCKY-TAMBE\\SQLEXPRESS ; integrated Security = True ; Database = Fendal_Solution ";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(Connection);
                da = new SqlDataAdapter("Select * from TableNation order by NationID ", con);
                ds = new DataSet();
                da.Fill(ds, "TableNation");
                comboBox1.DataSource = ds.Tables["TableNation"];
                comboBox1.DisplayMember = "NationName";
                comboBox1.ValueMember = "NationID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(Connection);
                    da = new SqlDataAdapter("Select * from TableCity where StateID=@StateID", con);
                    da.SelectCommand.Parameters.AddWithValue("@StateID", comboBox2.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds, "tablecity");
                    comboBox3.DataSource = ds.Tables["tablecity"];
                    comboBox3.DisplayMember = "CityName";
                    comboBox3.ValueMember = "CityID";

                }
                catch (Exception ex )
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(Connection);
                    da = new SqlDataAdapter("Select * from TableState1 where NationID=@NationID", con);
                    da.SelectCommand.Parameters.AddWithValue("@NationID", comboBox1.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds,"tablestate");
                    comboBox2.DataSource = ds.Tables["tablestate"];
                    comboBox2.DisplayMember = "StateName";
                    comboBox2.ValueMember = "StateID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        enum category { Student, IT_Professional }
        enum Gender { Male, Female, Other }

        category cat;
        Gender Gen;
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( textBox1.Text == "")
            {
                MessageBox.Show("Full Name Can't Be Blank");
            }
            else
            {
                if ( radioButton1.Checked )
                {
                    cat = category.Student;
                }
                else if ( radioButton2.Checked )
                {
                    cat = category.IT_Professional;
                }
                MessageBox.Show("Category " + cat);
            }

            if ( radioButton3.Checked )
            {
               Gen = Gender.Male;
            }
            else if (radioButton4.Checked )
            {
                Gen = Gender.Female;
            }
            MessageBox.Show("Gender Select" + Gen);

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked )
            {
                cat = category.IT_Professional;
                textBox2.Text = "3000";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked )
            {
                cat = category.Student;
                textBox2.Text = "1000";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            CalculateFees();
        }

        public void CalculateFees()
        {
            if (cat.ToString() == "Student")
            {

                textBox2.Text = "1000";
               
                float Ta = Convert.ToSingle(textBox2.Text);
                float Fp = Ta * 0.5f;
                float Amt = Convert.ToSingle(textBox3.Text);

                if (Amt < Fp)
                {
                    MessageBox.Show("Minimum Amount To Be Paid Is 80 Per");
                }
                else
                {
                    float BAmt = Ta - Amt;
                    textBox4.Text = BAmt.ToString();    
                }
            }
            else if (cat.ToString() == "IT_Professional")
            {
                textBox2.Text = "3000";

                float Ta = Convert.ToSingle(textBox2.Text);
                float Fp = Ta * 0.8f;
                float Amt = Convert.ToSingle(textBox3.Text);

                if (Fp < Amt)
                {
                    MessageBox.Show("Minimum Amount To Be Paid Is 80 Per");
                }
                else
                {
                    float BAmt = Ta - Amt;
                    textBox4.Text = BAmt.ToString();
                }

            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
