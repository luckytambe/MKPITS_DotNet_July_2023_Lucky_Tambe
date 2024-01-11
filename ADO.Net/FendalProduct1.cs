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

namespace Fendal_Product1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        
        }
        public enum Nationality { INDIAN, NRI }
        Nationality nat;

        string Connection = "Server = LUCKY-TAMBE\\SQLEXPRESS ; integrated Security = True ; Database = Fendal_Product1 ";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            getcatogery();
            getproduct();
            getprice();
            clear();
            nat = Nationality.INDIAN;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("enter only numbers");
            }

        }

        public void getcatogery()
        {
            con = new SqlConnection(Connection);
            try
                {
                     
                    da = new SqlDataAdapter("Select * from TableProductCategory order by Product_Category_ID", con);
                    ds = new DataSet();
                    da.Fill(ds, "TPC");
                    comboBox1.DataSource = ds.Tables["TPC"];
                    comboBox1.DisplayMember = "Product_Type_Name";
                    comboBox1.ValueMember = "Product_Category_ID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
        }

        public void getproduct()
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                con = new SqlConnection(Connection);
                try
                {
                    da = new SqlDataAdapter("Select * from Product  where Product_Category_ID=@Product_Category_ID", con);
                    da.SelectCommand.Parameters.AddWithValue("@Product_Category_ID", comboBox1.SelectedValue);
                    ds = new DataSet();
                    da.Fill(ds, "tp");
                    comboBox2.DataSource = ds.Tables["tp"];
                    comboBox2.DisplayMember = "ProductName";
                    comboBox2.ValueMember = "ProductID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }

        }

        public void getprice()
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                con = new SqlConnection(Connection);
                try
                {
                    da = new SqlDataAdapter("select * from Product where ProductID=@ProductID", con);
                    da.SelectCommand.Parameters.AddWithValue("@ProductID", comboBox2.SelectedValue);
                    ds = new DataSet();
                    da.Fill(ds, "Product_Price");

                   foreach(DataRow dr in ds.Tables["Product_Price"].Rows)
                    {
                        textBox12.Text = dr["Product_Price"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox12.Text = "0";
            getproduct();
            if(comboBox1.Text != "System.Data.DataRowView")
            {
                string CatName = comboBox1.Text;
                con = new SqlConnection(Connection);
                da = new SqlDataAdapter("select * from TableProductGSTDetails where Gst_Detail_Name =@ckk", con);
                da.SelectCommand.Parameters.AddWithValue("@Ckk" , CatName);
                da.Fill(ds,"FBB");
                foreach (DataRow dr in ds.Tables["FBB"].Rows)
                {
                    textBox3.Text = dr["CGST"].ToString();
                    textBox4.Text = dr["SGST"].ToString();
                    textBox5.Text = dr["IGST"].ToString();
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            getprice();
            textBox13.Text = "0";
            textBox14.Text = "0";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                nat = Nationality.INDIAN;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                nat = Nationality.NRI;
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (textBox13.Text != "")
            {
                double price = Convert.ToDouble(textBox12.Text);
                double quantity = Convert.ToDouble(textBox13.Text);
                double totalamount = price * quantity;
                textBox14.Text = totalamount.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox13.Clear();
            textBox14.Clear();

        }


    }
}
