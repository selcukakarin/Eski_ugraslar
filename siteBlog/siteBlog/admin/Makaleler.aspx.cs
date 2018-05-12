using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace siteBlog.admin
{
    public partial class Makaleler : System.Web.UI.Page
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        string makaleID = "";
        string islem = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yoneticiKullanici"] == null)
            {
                Response.Redirect("default.aspx");
            }

            makaleID = Request.QueryString["makaleID"];
            islem = Request.QueryString["islem"];

            if (islem == "sil")
            {
                SqlCommand cmdmsil = new SqlCommand("delete from Makale where makaleID='"+makaleID+"'", baglan.baglan());
                cmdmsil.ExecuteNonQuery();

            }

            if (Page.IsPostBack == false)
            {




                pnl_makaleEkle.Visible = true;
                PanelDuzenle.Visible = true;
                Panel_DosyaEkle.Visible = true;

                //kategorileri getir

                SqlCommand cmdkgetir = new SqlCommand("select * from Kategori", baglan.baglan());
                SqlDataReader drkgetir = cmdkgetir.ExecuteReader();

                ddlist_kategori.DataTextField = "kategoriAdi";
                ddlist_kategori.DataValueField = "kategoriID";

                ddlist_kategori.DataSource = drkgetir;
                ddlist_kategori.DataBind();

                //makale getir

                SqlCommand cmdmgetir = new SqlCommand("Select * from Makale", baglan.baglan());
                SqlDataReader drmgetir = cmdmgetir.ExecuteReader();

                DataList1.DataSource = drmgetir;
                DataList1.DataBind();

            }
        }

        protected void btmeArti_Click(object sender, EventArgs e)
        {
            pnl_makaleEkle.Visible = true;
        }

        protected void btmeEksi_Click(object sender, EventArgs e)
        {
            pnl_makaleEkle.Visible = false;
        }

        protected void btn_makaleekle_Click(object sender, EventArgs e)
        {
            if (fu_slider.HasFile)
            {
                fu_slider.SaveAs(Server.MapPath("/sresim/" + fu_slider.FileName));
                SqlCommand cmdmekle = new SqlCommand("insert into Makale(makaleBaslik,makaleOzet,makaleIcerik,makaleResim,kategoriID) Values('"+txt_mbaslik.Text+"','"+txt_ozet.Text+"','"+ckeditor.Text+"','/sresim/"+fu_slider.FileName+"','"+ddlist_kategori.SelectedValue+"')", baglan.baglan());
                cmdmekle.ExecuteNonQuery();

                SqlCommand cmdKAdet = new SqlCommand("update Kategori set kategoriAdet=kategoriAdet+1 where kategoriID='"+ddlist_kategori.SelectedValue+"'", baglan.baglan());
                cmdKAdet.ExecuteNonQuery();

                Response.Redirect("makaleler.aspx"); 
            }
            else
            {
                btn_makaleekle.Text = "Resim EKLE!!"; 
            }
        }

        protected void makaleDuzenleArti_Click(object sender, EventArgs e)
        {
            PanelDuzenle.Visible = true;
        }

        protected void makaleDuzenleEksi_Click(object sender, EventArgs e)
        {
            PanelDuzenle.Visible = false;
        }

        protected void Btn_DosyaEkleEksi_Click(object sender, EventArgs e)
        {
            Panel_DosyaEkle.Visible = false;
        }

        protected void Bnt_DosyaEkleArti_Click(object sender, EventArgs e)
        {
            Panel_DosyaEkle.Visible = true;
        }

        protected void btn_makaleDosyaEkle_Click(object sender, EventArgs e)
        {
            if (fu_makaleDosya.HasFile)
            {
                fu_makaleDosya.SaveAs(Server.MapPath("/dosyalar/" + fu_makaleDosya.FileName));

                Response.Redirect("Makaleler.aspx");
            }
            else
            {
                btn_makaleDosyaEkle.Text = "Dosya EKLE!!";
            }
        }
    }
}