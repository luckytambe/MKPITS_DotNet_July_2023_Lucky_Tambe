using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pro_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /* int Number1 = Convert.ToInt32(TextBox1.Text);
            Char OP = Convert.ToChar(TextBox2.Text);
            int Number2 = Convert.ToInt32(TextBox3.Text);
            int res = 0;

            if (OP == '+')
                res = Number1 + Number2;
            else if (OP == '-')
                res = Number1 - Number2;
            else if (OP == '*')
                res = Number1 * Number2;
            else if (OP == '/')
                res = Number1 / Number2;
            else
                Label1.Text = "Invalid Characters";
              Label1.Text = res .ToString(); */

            int Number1 = Convert.ToInt32(TextBox1.Text);
            Char OP = Convert.ToChar(TextBox2.Text);
            int Number2 = Convert.ToInt32(TextBox3.Text);
            int res = 0;

            switch (OP)
            {
                case '+':
                    res = Number1 + Number2;
                    break;
                case '-':
                    res = Number1 - Number2;
                    break;
                case '*':
                    res = Number1 * Number2;
                    break;
                case '/':
                    res = Number1 / Number2;
                    break;

                default:
                    Response.Write("invalid character");
                    break;
            }
            Label1.Text = res.ToString();
        }
    }
}