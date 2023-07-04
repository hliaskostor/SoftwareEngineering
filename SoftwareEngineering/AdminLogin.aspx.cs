using System;
using System.Data;
using System.Data.OleDb;

namespace SoftwareEngineering
{
    public partial class AdminLogin : HomePage
    {
        public OleDbConnection conn;
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
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kosto\source\repos\SoftwareEngineering\SoftwareEngineering\erg11.accdb");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            //username:admin,password:admin
            try
            {
                string uid = TextBox1.Text;
                string pass = TextBox3.Text;
                conn.Open();
                string qry = "select * from Admin where Username='" + uid + "' and Password='" + pass + "'";
                OleDbCommand cmd = new OleDbCommand(qry, conn);
                OleDbDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    Response.Redirect("AdminPage.aspx");
                }
                else
                {
                    Label4.Text = "UserId & Password Is not correct Try again..!!";

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
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