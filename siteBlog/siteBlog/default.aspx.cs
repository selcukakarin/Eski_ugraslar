using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace siteBlog
{
    public partial class _default : System.Web.UI.Page
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand cmdmakale = new SqlCommand("SELECT dbo.Makale.makaleBaslik, dbo.Makale.makaleOzet, dbo.Makale.makaleTarih, dbo.Makale.makaleID , dbo.Makale.makaleOkunma, dbo.Makale.makaleYorumSayisi, dbo.Kategori.kategoriResim FROM dbo.Kategori INNER JOIN dbo.Makale ON dbo.Kategori.kategoriID = dbo.Makale.kategoriID order by makaleID desc", baglan.baglan());
            SqlDataReader drMakaleGetir = cmdmakale.ExecuteReader();

            dl_MakaleGetir.DataSource = drMakaleGetir;
            dl_MakaleGetir.DataBind();


        }
    }
}