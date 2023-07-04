using SoftwareEngineering;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftwareEngineering

{
    public partial class Insert : System.Web.UI.Page, IAdminPage, ICustomerMenu
    {
        public OleDbConnection conn;
        public OleDbDataAdapter dnd;
        public DataSet ds;
        public OleDbCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["PreviousPage"] =
            Request.UrlReferrer;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            OleDbConnection vaccine = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kosto\source\repos\SoftwareEngineering\SoftwareEngineering\erg11.accdb");
            OleDbCommand cmd = new OleDbCommand("insert into[Show] values('" + TextBox2.Text + "') ");
            cmd.Connection = vaccine;
            vaccine.Open();
            int vac = cmd.ExecuteNonQuery();
            vaccine.Close();
            //εμφάνιση μηνύματος άν η εισαγωγή ήταν επιτυχής//
            if (vac > 0)
            {

                Label2.Visible = true;

            }

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (ViewState["PreviousPage"] != null)
            {
                Response.Redirect(ViewState["PreviousPage"].ToString());
            }
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