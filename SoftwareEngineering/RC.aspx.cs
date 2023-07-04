using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftwareEngineering
{
   
     
        public partial class RC : System.Web.UI.Page, IAdminPage, ICustomerMenu, IVisitorMenu
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
                    conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kosto\source\repos\SoftwareEngineering\SoftwareEngineering\erg11.accdb");
                    conn.Open();
                    dnd = new OleDbDataAdapter("SELECT * from Restaurant", conn);
                    ds = new DataSet();
                    dnd.Fill(ds);
                    GridView1.DataSource = ds;
                    GridView1.DataBind();
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
    
