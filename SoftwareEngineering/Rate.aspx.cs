using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftwareEngineering
{
    public abstract partial class Rate : System.Web.UI.Page, IAdminPage, IVisitorMenu, ICustomerMenu
    {
        public OleDbConnection rest;
        public OleDbDataAdapter dnd;
        public OleDbCommand cmd;
        public DataSet ds;

    

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["PreviousPage"] =
            Request.UrlReferrer;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            OleDbConnection rest = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kosto\source\repos\SoftwareEngineering\SoftwareEngineering\erg11.accdb");
            OleDbCommand cmd = new OleDbCommand("insert into[Restaurant] values( '" + Name.Text + "','" + List1.Text + "','" + StarsList.Text + "','" + TextBox3.Text + "') ");
            cmd.Connection = rest;
            rest.Open();
            int vac = cmd.ExecuteNonQuery();
            rest.Close();
            //εμφάνιση μηνύματος άν η εισαγωγή ήταν επιτυχής//
            if (vac > 0)
            {

                Label6.Visible = true;

            }
        }


        protected void List1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void StarsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void List1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (ViewState["PreviousPage"] != null)
            {
                Response.Redirect(ViewState["PreviousPage"].ToString());
            }

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
    }
}
