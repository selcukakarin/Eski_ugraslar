using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace siteBlog
{
    
    public partial class makaleDetay : System.Web.UI.Page
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        string makaleID = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            makaleID = Request.QueryString["makaleID"];

            if (Page.IsPostBack == false)
            {

                //makaleGetir
            SqlCommand cmdmakale = new SqlCommand("SELECT dbo.Makale.makaleBaslik, dbo.Makale.makaleIcerik, dbo.Makale.makaleID, dbo.Makale.makaleTarih, dbo.Makale.makaleOkunma, dbo.Makale.makaleYorumSayisi, dbo.Kategori.kategoriResim, dbo.Kategori.kategoriID FROM dbo.Kategori INNER JOIN dbo.Makale ON dbo.Kategori.kategoriID = dbo.Makale.kategoriID where  dbo.Makale.makaleID='" + makaleID + "'", baglan.baglan());
            SqlDataReader drmakale = cmdmakale.ExecuteReader();

            dl_MakaleGetir.DataSource = drmakale;
            dl_MakaleGetir.DataBind();

                //makaleOkunmaSayısı
                SqlCommand cmdOkunma = new SqlCommand("update  Makale set makaleOkunma=makaleOkunma+1 where makaleID='"+makaleID+"'", baglan.baglan());
                cmdOkunma.ExecuteNonQuery();

                //yorumGetir
                SqlCommand cmdYorumGetir = new SqlCommand("Select * from Yorum where makaleID='"+makaleID+"' and yorumOnay=1",baglan.baglan());
                SqlDataReader drYorumGetir = cmdYorumGetir.ExecuteReader();

                dl_yorumGetir.DataSource = drYorumGetir;
                dl_yorumGetir.DataBind();

            }
        }

        protected void btn_YorumEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmdYorumEkle = new SqlCommand("insert into Yorum(yorumAdSoyad,yorumEmail,yorumIcerik,yorumResim,makaleID) Values('"+txt_AdSoyad.Text+"','"+txt_Email.Text+"','"+txt_YorumIcerik.Text+"','/tema/yorumcu.png','"+makaleID+"')", baglan.baglan());
            cmdYorumEkle.ExecuteNonQuery();
            lbl_bilgi.Text = "Yorumunuz Başarıyla Eklendi";
            txt_AdSoyad.Text = "";
            txt_Email.Text = "";
            txt_YorumIcerik.Text = "";
        }
    }
}