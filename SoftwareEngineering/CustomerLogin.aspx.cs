using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftwareEngineering
{
    public partial class CustomerLogin : HomePage
    {
        public OleDbConnection conn;
        public OleDbDataAdapter dnd;
        public OleDbCommand cmd;
        public DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kosto\source\repos\SoftwareEngineering\SoftwareEngineering\erg11.accdb");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string uid = TextBox1.Text;
                string pass = TextBox3.Text;
                conn.Open();
                string qry = "select * from Register where Username='" + uid + "' and Password='" + pass + "'";
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

        public class Login
        {
            string username;
            string password;
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("RegistUser.aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            try
            {
                string uid = TextBox1.Text;
                string pass = TextBox3.Text;
                conn.Open();
                string qry = "select * from Register where Username='" + uid + "' and Password='" + pass + "'";
                OleDbCommand cmd = new OleDbCommand(qry, conn);
                OleDbDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    Response.Redirect("CustomerMenu.aspx");
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
            Response.Redirect("HomePage.aspx");
        }
    }
}