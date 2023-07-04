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
    public partial class RegistUser : System.Web.UI.Page
    {
        public OleDbConnection conn;
        public OleDbDataAdapter dnd;
        public OleDbCommand cmd;
        public DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kosto\source\repos\SoftwareEngineering\SoftwareEngineering\erg11.accdb");
            conn.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            OleDbConnection vaccine = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kosto\source\repos\SoftwareEngineering\SoftwareEngineering\erg11.accdb");
            OleDbCommand cmd = new OleDbCommand("insert into[Register] values( '" + Name.Text + "','" + Username.Text + "','" + Email.Text + "','" + TextBox1.Text + "') ");
            cmd.Connection = vaccine;
            vaccine.Open();
            int vac = cmd.ExecuteNonQuery();
            vaccine.Close();
      
            if (vac > 0)
            {
                Response.Redirect("CustomerLogin.aspx");


            }
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Name_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Username_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}