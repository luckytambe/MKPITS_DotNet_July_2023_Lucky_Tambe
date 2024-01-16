using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assign_Pro7_Three_Sub
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int Number1 = Convert.ToInt32(TextBox1.Text);
            int Number2 = Convert.ToInt32(TextBox2.Text);
            int Number3 = Convert.ToInt32(TextBox3.Text);
            float Total;
            float per;
            string  grade;

            Total = Number1 + Number2 + Number3;
            per = (Total / 300) * 100.0f;

            if (per >= 90)
            {
                grade = "A";
            }
            else if (per > 60 && per < 80 )
            {
                grade = "B";
            }
            else if ( per > 35 && per <= 60 )
            {
                grade = "C";
            }
            else
            {
                grade = "Fale";
            }


            Label1.Text = Total.ToString();
            Label2.Text = per.ToString();
            Label3.Text = grade.ToString();

        }
    }
}