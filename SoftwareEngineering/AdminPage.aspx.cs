using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftwareEngineering
{
    public interface IAdminPage
    {
        void RankButton_Click(object sender, EventArgs e);
        void InsertButton_Click(object sender, EventArgs e);
        void RateButton_Click(object sender, EventArgs e);
        void LogOut_Click1(object sender, EventArgs e);
        void rcButton_Click1(object sender, EventArgs e);
        void UsersButton_Click1(object sender, EventArgs e);
        void ViewRest_Click(object sender, EventArgs e);
    }
    public partial class AdminPage : AdminLogin, IAdminPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void RankButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Results.aspx");
        }

        public void InsertButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Insert.aspx");
        }

        public void RateButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Rate.aspx");
        }

        public void LogOut_Click1(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        public void rcButton_Click1(object sender, EventArgs e)
        {
            Response.Redirect("RC.aspx");
        }

        public void UsersButton_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Users.aspx");
        }



        public void ViewRest_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewRest.aspx");
        }
    }
}