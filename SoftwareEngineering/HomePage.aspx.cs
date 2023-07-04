using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftwareEngineering
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Admin_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogin.aspx");

        }

        protected void Customer_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerLogin.aspx");
        }
        protected void Visitor_Click1(object sender, EventArgs e)
        {
            Response.Redirect("VisitorMenu.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}