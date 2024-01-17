using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registration_Form
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string C = DropDownList1.Text;
            DropDownList2.Items.Clear();
            switch (C)
            {
                case "India":
                    DropDownList2.Items.Add("Nagpur");
                    DropDownList2.Items.Add("Mumbail");
                    DropDownList2.Items.Add("Pune");
                    break;
                case "Pakistan":
                    DropDownList2.Items.Add("Turkistan");
                    DropDownList2.Items.Add("Punjab");
                    DropDownList2.Items.Add("Nayebasti");
                    break;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("User Name : " + TextBox1.Text + "<br>");
            sb.Append("PassWord : " + TextBox2.Text + "<br>");
            sb.Append("Address : " + TextBox3.Text + "<br>");


            String G = null;
            if (Male.Checked)
            {
                G = Male.Text;
            }
            else if (Female.Checked)
            {
                G = Female.Text;
            }
            sb.Append("Gender : " + G + "<br>");

           

            String H = null;
            if (Hockey.Checked)
            {
                H = H + " " + Hockey.Text;
            }
            if (Cricket.Checked)
            { 
                H = H + " " + Cricket.Text;
            }
            if (Football.Checked)
            {
                H = H + " " + Football.Text;
            }
            sb.Append("Hobby : " + H + "<br>");
            sb.Append("Country : " + DropDownList1.Text + "<br>");
            sb.Append("City : " + DropDownList2.Text + "<br>");
            sb.Append("Course  : " + DropDownList3.Text + "<br>");
            Label1.Text = sb.ToString();
        }
       
        protected void Male_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList3.Items.Add("JAVA");
            DropDownList3.Items.Add(".Net");
            DropDownList3.Items.Add("Python");
            
           
        }
       
    }
}