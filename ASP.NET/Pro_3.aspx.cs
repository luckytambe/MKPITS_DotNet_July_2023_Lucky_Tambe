using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pro_3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int Number = Convert.ToInt32(TextBox1.Text);            
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            int i = 1;
            while ( i <= Number)
            {
                sb.Append(i + "<br>");
                i++;
            }
        
            Label1.Text = sb.ToString();

        }
    }
}