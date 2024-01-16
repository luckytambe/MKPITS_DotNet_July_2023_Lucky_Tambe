using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assign_Pro5_Length_breath
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int Length = Convert.ToInt32(TextBox1.Text);
            int Breath = Convert.ToInt32(TextBox2.Text);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int Reactangle = Length * Breath;
            Label1.Text = Reactangle.ToString();
        }
    }
}