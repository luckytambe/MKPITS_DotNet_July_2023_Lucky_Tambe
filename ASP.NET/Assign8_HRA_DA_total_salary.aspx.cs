using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assign8_HRA_DA_total_salary
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string EmployeName = TextBox1.Text;
            int BasicSalary = Convert.ToInt32(TextBox2.Text);
            String Designation = TextBox3.Text;

            float hra = 0;  ;
            float da = 0;
            float totalsalary = 0;

            if (Designation == "manager")
            {
                hra = BasicSalary * 0.45f;
                da = BasicSalary * 0.35f;
                totalsalary = BasicSalary + hra + da;

            }
            else if ( Designation == "peon")
            {
                hra = BasicSalary * 0.25f;
                da = BasicSalary * 0.15f;
                totalsalary = BasicSalary + hra + da;
            }

            Label1.Text = hra.ToString();
            Label2.Text = da.ToString();
            Label3.Text = totalsalary.ToString();

        }
    }
}