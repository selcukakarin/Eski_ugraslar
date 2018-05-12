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
    public partial class yorumGuncelle : System.Web.UI.Page
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        string yorumID = "";
        string makaleID = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yoneticiKullanici"]==null)
            {
                Response.Redirect("default.aspx");
            }

            yorumID = Request.QueryString["yorumID"];
            if (Page.IsPostBack == false)
            {
                SqlCommand cmdYorumGetir = new SqlCommand("Select * from Yorum where yorumID='" + yorumID + "'", baglan.baglan());
                SqlDataReader drYorumGetir = cmdYorumGetir.ExecuteReader();

                DataTable dtYorumGetir = new DataTable("tablo");
                dtYorumGetir.Load(drYorumGetir);

                DataRow row = dtYorumGetir.Rows[0];
                txt_adsoyad.Text = row["yorumAdSoyad"].ToString();
                txt_icerik.Text = row["yorumIcerik"].ToString();
            }
        }

        protected void btn_guncelle_Click(object sender, EventArgs e)
        {
            makaleID = Request.QueryString["makaleID"];

            
            SqlCommand cmdOnay = new SqlCommand("update Yorum set yorumAdSoyad='" + txt_adsoyad.Text + "',yorumIcerik='" + txt_icerik.Text + "',yorumOnay='" + cbox_onay.Checked + "' where yorumID='" + yorumID + "'", baglan.baglan());
            cmdOnay.ExecuteNonQuery();



            if (cbox_onay.Checked == true)
            {
                SqlCommand cmdEkle = new SqlCommand("update Makale set makaleYorumSayisi=makaleYorumSayisi+1 where makaleID='" + makaleID + "'",baglan.baglan());
                cmdEkle.ExecuteNonQuery();
                Response.Redirect("yorumlar.aspx");
            }
            if (cbox_onay.Checked == false)
            {
                SqlCommand cmdAzalt = new SqlCommand("update Makale set makaleYorumSayisi=makaleYorumSayisi-1 where makaleID='"+makaleID+"'",baglan.baglan());
                cmdAzalt.ExecuteNonQuery();
                Response.Redirect("yorumlar.aspx");


            }
            
        }
    }
}