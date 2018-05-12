using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace siteBlog.admin
{
    public partial class kategoriler : System.Web.UI.Page
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        string kategoriID = "";
        string islem = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yoneticiKullanici"]==null)
            {
                Response.Redirect("default.aspx");
            }

            kategoriID = Request.QueryString["kategoriID"];
            islem = Request.QueryString["islem"];

            if (islem == "sil")
            {
                SqlCommand cmdsil = new SqlCommand("delete from Kategori where kategoriID='" + kategoriID + "'", baglan.baglan());
                cmdsil.ExecuteNonQuery();
            }


            if (Page.IsPostBack == false)
            {
                pnl_kategoriEkle.Visible = true;
                pnl_kategoriDuzenle.Visible = true;
            }

            SqlCommand cmdkgetir = new SqlCommand("select * from Kategori", baglan.baglan());
            SqlDataReader drkgetir = cmdkgetir.ExecuteReader();
            dl_kategoriGetir.DataSource = drkgetir;
            dl_kategoriGetir.DataBind();

        }

        protected void btkeArti_Click(object sender, EventArgs e)
        {
            pnl_kategoriEkle.Visible = true;
        }

        protected void btkeEksi_Click(object sender, EventArgs e)
        {
            pnl_kategoriEkle.Visible = false;
        }

        protected void btn_kategoriEkle_Click(object sender, EventArgs e)
        {
            if (fu_kategoriResim.HasFile)
            {
                fu_kategoriResim.SaveAs(Server.MapPath("/kresim/" + fu_kategoriResim.FileName));
                SqlCommand cmdekle = new SqlCommand("insert into Kategori(kategoriAdi,kategoriSira,kategoriResim) Values ('"+txt_kategoriAdi.Text+"','"+txt_Sira.Text+"','/kresim/"+fu_kategoriResim.FileName+"')",baglan.baglan());
                cmdekle.ExecuteNonQuery();
                Response.Redirect("kategoriler.aspx");

            }else
            {
                btn_kategoriEkle.Text="Resim EKLE!!"; 
            }
        }

        protected void btn_KategoriDuzenArti_Click(object sender, EventArgs e)
        {
            pnl_kategoriDuzenle.Visible = true;
        }

        protected void btn_kategoriDuzenEksi_Click(object sender, EventArgs e)
        {
            pnl_kategoriDuzenle.Visible = false;
        }
    }
}