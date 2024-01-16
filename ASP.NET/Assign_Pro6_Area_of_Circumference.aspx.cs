using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assign_Pro6_Area_of_Circumference
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int radius = Convert.ToInt32(TextBox1.Text);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            Double Area ;
            Area =  3.14 * radius * radius;
            Label1.Text = Area.ToString();

            Double circle;
            circle = 2 * 3.14 * radius;
            Label2.Text = circle.ToString();


        }
    }
}