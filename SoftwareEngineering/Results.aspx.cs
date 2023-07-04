using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftwareEngineering
{
    public partial class Results : System.Web.UI.Page, IAdminPage, IVisitorMenu, ICustomerMenu
    {
        public OleDbConnection conn;
        public OleDbDataAdapter dnd;
        public DataSet ds;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["PreviousPage"] = Request.UrlReferrer;


                conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kosto\source\repos\SoftwareEngineering\SoftwareEngineering\erg11.accdb");
                conn.Open();
                dnd = new OleDbDataAdapter("SELECT Name, AVG(Stars) AS Stars FROM Restaurant GROUP BY Name ORDER BY AVG(Stars) DESC;", conn);
                ds = new DataSet();
                dnd.Fill(ds);
                ResultRest1.DataSource = ds;
                ResultRest1.DataBind();
            }
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView2.Visible = true;
        }



        public void LogOut_Click1(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
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


        void IVisitorMenu.LogOut_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void IVisitorMenu.Button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void IVisitorMenu.RateButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void IVisitorMenu.rcButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void ICustomerMenu.Button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void ICustomerMenu.InsertButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void ICustomerMenu.RateButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void ICustomerMenu.LogOut_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void ICustomerMenu.rcButton_Click1(object sender, EventArgs e)
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

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (ViewState["PreviousPage"] != null)
            {
                Response.Redirect(ViewState["PreviousPage"].ToString());
            }
        }
    }
}

