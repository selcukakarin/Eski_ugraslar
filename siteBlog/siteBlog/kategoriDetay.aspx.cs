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
    public partial class kategoriDetay : System.Web.UI.Page
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        string kategoriID = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            kategoriID = Request.QueryString["kategoriID"];

            SqlCommand cmd = new SqlCommand("SELECT dbo.Makale.makaleBaslik, dbo.Makale.makaleOzet, dbo.Makale.makaleTarih, dbo.Makale.makaleID, dbo.Makale.makaleOkunma, dbo.Makale.makaleYorumSayisi, dbo.Kategori.kategoriResim, dbo.Kategori.kategoriID FROM dbo.Kategori INNER JOIN dbo.Makale ON dbo.Kategori.kategoriID = dbo.Makale.kategoriID where  dbo.Kategori.kategoriID='"+kategoriID+"'", baglan.baglan());
            SqlDataReader drkategori = cmd.ExecuteReader();

            dl_kategori.DataSource = drkategori;
            dl_kategori.DataBind();

        }
    }
}