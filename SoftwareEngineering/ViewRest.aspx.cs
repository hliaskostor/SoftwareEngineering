using SoftwareEngineering;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftwareEngineering
{
    public partial class ViewRest : System.Web.UI.Page, IAdminPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["PreviousPage"] =
            Request.UrlReferrer;
            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (ViewState["PreviousPage"] != null)
            {
                Response.Redirect(ViewState["PreviousPage"].ToString());
            }
        }

        void IAdminPage.RankButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void IAdminPage.InsertButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void IAdminPage.RateButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void IAdminPage.LogOut_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void IAdminPage.rcButton_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void IAdminPage.UsersButton_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void IAdminPage.ViewRest_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}