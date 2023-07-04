using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace SoftwareEngineering
{
    public partial class Users : System.Web.UI.Page, IAdminPage
    {
        public OleDbConnection conn;
        public OleDbDataAdapter dnd;
        public DataSet ds;
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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        void IAdminPage.RankButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void ViewRest_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}