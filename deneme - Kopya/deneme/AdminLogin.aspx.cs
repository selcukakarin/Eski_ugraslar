using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;

namespace deneme
{
    public partial class AdminLogin : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("Adminpnl.aspx");
            }
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["baglantim"].ConnectionString;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elvan\Desktop\Yeni klasör (2)\deneme - Kopya\deneme\App_Data\Database1.mdf;Integrated Security=True");
            con.Open();
            string userName = txtuser.Value;
            string password = txtpass.Value;
            SqlCommand com = new SqlCommand("Select * from Login where userName='" + userName + "' and userPassword='" + password + "'", con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                Session.Add("user", userName);
                Response.Redirect("Adminpnl.aspx");
            }
            else
            {
                button.Text = "HATALI GİRİŞ!!";
                button.CssClass = "buttonWrong";
            }
            con.Close();
        }
    }
}