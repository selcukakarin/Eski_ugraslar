using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace siteBlog.admin
{
    public partial class _default : System.Web.UI.Page
    {
        sqlbaglantisi bag = new sqlbaglantisi();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_giris_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Yonetici where yoneticiKullanici='"+txt_kullanici.Text+"' and  yoneticiSifre='"+txt_sifre.Text+"'", bag.baglan());
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Session["yoneticiKullanici"] = dr["yoneticiKullanici"];

                Response.Redirect("duyurular.aspx");

            }
            else
            {
                lbl_bilgi.Text = "Hatalı Giriş Yaptınız!!";
            }

        }
    }
}