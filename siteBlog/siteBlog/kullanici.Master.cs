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
    public partial class kullanici : System.Web.UI.MasterPage
    {
        sqlbaglantisi baglan = new sqlbaglantisi();

        protected void Page_Load(object sender, EventArgs e)
        {   
            //slider
            SqlCommand cmdslider = new SqlCommand("Select TOP 5 * from Makale order by makaleOkunma Desc",baglan.baglan());
            SqlDataReader drslider = cmdslider.ExecuteReader();

            datalist_slider.DataSource = drslider;
            datalist_slider.DataBind();

            //duyurular
            SqlCommand cmdduyuru = new SqlCommand("Select TOP 5 * from Duyurular order by duyurularID desc", baglan.baglan());
            SqlDataReader datareader_duyuru = cmdduyuru.ExecuteReader();

            datalist_duyuru.DataSource = datareader_duyuru;
            datalist_duyuru.DataBind();

            //kategoriler
            SqlCommand cmdkategoriler = new SqlCommand("Select * from Kategori", baglan.baglan());
            SqlDataReader datareader_kategoriler = cmdkategoriler.ExecuteReader();

            dl_kategori.DataSource = datareader_kategoriler;
            dl_kategori.DataBind();



        }

        protected void btn_ara_Click(object sender, EventArgs e)
        {
            Response.Redirect("araDetay.aspx?aranankelime=" + txt_ara.Text);
        }
    }
}