using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pro_4
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
            /* int i = 1 ;

                       do
                       {
                           sb.Append(i + "<br>");
                           i++;
                       }
                       while (i <= Number);
                       {
                           Label1.Text = sb.ToString();    
                       }
            */

            for ( int i = 1; i <= Number; i++ )
            {
                sb.Append(i + "<br>");
            }
            Label1.Text = sb.ToString();


        }
    }
}