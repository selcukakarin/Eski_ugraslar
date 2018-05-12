using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace siteBlog
{
    public partial class araDetay : System.Web.UI.Page
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        string aranankelime = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            aranankelime = Request.QueryString["aranankelime"];

            if (Page.IsPostBack==false)
            {
                SqlCommand cmdara = new SqlCommand("SELECT dbo.Makale.makaleBaslik, dbo.Makale.makaleOzet, dbo.Makale.makaleIcerik, dbo.Makale.makaleTarih, dbo.Makale.makaleID , dbo.Makale.makaleOkunma, dbo.Makale.makaleYorumSayisi, dbo.Kategori.kategoriResim FROM dbo.Kategori INNER JOIN dbo.Makale ON dbo.Kategori.kategoriID = dbo.Makale.kategoriID where makaleBaslik like '%"+aranankelime+"%' or makaleOzet like '%"+aranankelime+"%' or makaleIcerik like '%"+aranankelime+"%'", baglan.baglan());
                SqlDataReader drara = cmdara.ExecuteReader();
                dl_ara.DataSource = drara;
                dl_ara.DataBind();
            }


        }
    }
}