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
    public partial class yorumlar : System.Web.UI.Page
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        string yorumID="";
        string islem="";
        string islemiki = "";
        string makaleID = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yoneticiKullanici"] == null)
            {
                Response.Redirect("default.aspx");
            }

            yorumID = Request.QueryString["yorumID"];
            islem = Request.QueryString["islem"];
            islemiki = Request.QueryString["islemiki"];
            makaleID = Request.QueryString["makaleID"];

            if (islemiki == "siliki")
            {
                SqlCommand cmdsil = new SqlCommand("delete from Yorum where yorumID='" + yorumID + "'", baglan.baglan());
                cmdsil.ExecuteNonQuery();

                SqlCommand cmdazalt = new SqlCommand("update Makale set makaleYorumSayisi=makaleYorumSayisi-1 where makaleID='"+makaleID+"'", baglan.baglan());
                cmdazalt.ExecuteNonQuery();
                Response.Redirect("yorumlar.aspx");
            }

            if (islem =="sil")
            {
                SqlCommand cmdSil = new SqlCommand("delete from  Yorum where yorumID='" + yorumID + "'", baglan.baglan());
                cmdSil.ExecuteNonQuery();
                Response.Redirect("yorumlar.aspx");
            }


            if (Page.IsPostBack == false)
            {
                pnl_onasizyorum.Visible = true;
                pnl_onaylananYorum.Visible = true;

                //onaysız yorumlar
                SqlCommand cmdyorum = new SqlCommand("SELECT dbo.Makale.makaleID AS Expr1, dbo.Makale.makaleBaslik, dbo.Makale.makaleYorumSayisi, dbo.Yorum.yorumID, dbo.Yorum.yorumAdSoyad, dbo.Yorum.yorumEmail, dbo.Yorum.yorumIcerik, dbo.Yorum.yorumTarih, dbo.Yorum.yorumOnay, dbo.Yorum.yorumResim, dbo.Yorum.makaleID FROM dbo.Makale INNER JOIN dbo.Yorum ON dbo.Makale.makaleID = dbo.Yorum.makaleID where yorumOnay=0", baglan.baglan());
                SqlDataReader dryorum = cmdyorum.ExecuteReader();

                dl_yorum.DataSource = dryorum;
                dl_yorum.DataBind();
                //onaylı yorumlar
                SqlCommand cmdonayli = new SqlCommand("SELECT dbo.Makale.makaleID AS Expr1, dbo.Makale.makaleBaslik, dbo.Makale.makaleYorumSayisi, dbo.Yorum.yorumID, dbo.Yorum.yorumAdSoyad, dbo.Yorum.yorumEmail, dbo.Yorum.yorumIcerik, dbo.Yorum.yorumTarih, dbo.Yorum.yorumOnay, dbo.Yorum.yorumResim, dbo.Yorum.makaleID FROM dbo.Makale INNER JOIN dbo.Yorum ON dbo.Makale.makaleID = dbo.Yorum.makaleID where yorumOnay=1", baglan.baglan());
                SqlDataReader dronayli = cmdonayli.ExecuteReader();

                dl_onayli.DataSource = dronayli;
                dl_onayli.DataBind();


            }

        }

        protected void btkeArti_Click(object sender, EventArgs e)
        {
            pnl_onasizyorum.Visible = true;
        }

        protected void btkeEksi_Click(object sender, EventArgs e)
        {
            pnl_onasizyorum.Visible = false;
        }

        protected void btn_onaylananarti_Click(object sender, EventArgs e)
        {
            pnl_onaylananYorum.Visible = true;
        }

        protected void btn_onaylananeksi_Click(object sender, EventArgs e)
        {
            pnl_onaylananYorum.Visible = false;
        }
    }
}