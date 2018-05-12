using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace masterBlog
{
    public partial class adminGiris : System.Web.UI.Page
    {
        sqlbaglanti bag = new sqlbaglanti();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_giris_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from yonetici where yoneticiAdi='" + TextBox1.Text + "' and yoneticiSifre='" + TextBox2.Text + "'", bag.baglan());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Response.Redirect("adminBlog.aspx");
            }
            else
            {
                lbl_giris.Text = "Hatalı Giriş";
            }
            
        }
    }
}