using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Course_Registration_Form
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c = DropDownList1.Text;
            DropDownList2.Items.Clear();
             DropDownList3.Items.Clear();
            switch (c)
            {
                case "India":
                    DropDownList2.Items.Add("Maharashtra");
                    DropDownList2.Items.Add("Gujrat");
                    break;
                case "Pakistan":
                    DropDownList2.Items.Add("Panjab");
                    DropDownList2.Items.Add("Lahor");
                    break;
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c = DropDownList2.Text;
           DropDownList3.Items.Clear();
            switch(c)
            {
                case "Maharashtra":
                    DropDownList3.Items.Add("Mumbai");
                    DropDownList3.Items.Add("Pune");
                    DropDownList3.Items.Add("Nagpur");
                    break;
                case "Gujrat":
                    DropDownList3.Items.Add("Imamwada");
                    DropDownList3.Items.Add("laki");
                    DropDownList3.Items.Add("Puki");
                    break;

                case "Panjab":
                    DropDownList3.Items.Add("Teka-Naka");
                    DropDownList3.Items.Add("NaviBasti");
                    DropDownList3.Items.Add("Mominpura");
                    break;
                case "Lahor":
                    DropDownList3.Items.Add("Jafar-nagar");
                    DropDownList3.Items.Add("Tajbag");
                    DropDownList3.Items.Add("4-Khamba");
                    break;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("Full Name : " + TextBox1.Text + "<br>");

            String G = null;
            if (RadioButton6.Checked)
                G = "Male";
            else if (RadioButton7.Checked)
                G = "Female";
            else if (RadioButton8.Checked)
                G = "Other";

            sb.Append("Gender : " + G + "<br>");

            Label1.Text = sb.ToString();    
             
        }

        protected void RadioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioButton9.Checked)
            {
                TextBox3.Text = "1000";
            }
        }

        protected void RadioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioButton10.Checked)
            {
                TextBox3.Text = "3000";
            }
        }
    }
}