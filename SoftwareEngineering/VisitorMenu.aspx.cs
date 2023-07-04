using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftwareEngineering
{
    public interface IVisitorMenu
    {
        void LogOut_Click1(object sender, EventArgs e);
        void Button1_Click(object sender, EventArgs e);
        void RateButton_Click(object sender, EventArgs e);
        void rcButton_Click(object sender, EventArgs e);
    }

    public partial class VisitorMenu : HomePage, IVisitorMenu
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void LogOut_Click1(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Results.aspx");
        }

        public void RateButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Rate.aspx");
        }

        public void rcButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("RC.aspx");
        }
    }
}