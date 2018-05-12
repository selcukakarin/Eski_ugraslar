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
    public partial class kategori_Guncelle : System.Web.UI.Page
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        string kategoriID = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yoneticiKullanici"] == null)
            {
                Response.Redirect("default.aspx");
            }

            kategoriID = Request.QueryString["kategoriID"];

            if (Page.IsPostBack == false)
            {
                SqlCommand cmdkguncelle = new SqlCommand("Select * from Kategori where kategoriID='"+kategoriID+"'", baglan.baglan());
                SqlDataReader drkguncelle = cmdkguncelle.ExecuteReader();

                DataTable dtKGuncelle = new DataTable("tablo");
                dtKGuncelle.Load(drkguncelle);

                DataRow row = dtKGuncelle.Rows[0];
                txtKategoriAdi.Text = row["kategoriAdi"].ToString();
                txt_kSira.Text = row["kategoriSira"].ToString();
                txt_kAdet.Text = row["kategoriAdet"].ToString();

            }
        }

        protected void btn_kGuncelle_Click(object sender, EventArgs e)
        {
            if (fu_kResim.HasFile)
            {
                fu_kResim.SaveAs(Server.MapPath("/kresim/" + fu_kResim.FileName));

                SqlCommand cmdkguncelle = new SqlCommand("Update Kategori Set kategoriAdi='"+txtKategoriAdi.Text+"', kategoriSira='"+txt_kSira.Text+"', kategoriAdet='"+txt_kAdet.Text+"',kategoriResim='/kresim/"+fu_kResim.FileName+"' where kategoriID='"+kategoriID+"' ", baglan.baglan());
                cmdkguncelle.ExecuteNonQuery();

                Response.Redirect("kategoriler.aspx");
            }
            else
            {
                SqlCommand cmdkguncelle = new SqlCommand("Update Kategori Set kategoriAdi='" + txtKategoriAdi.Text + "', kategoriSira='" + txt_kSira.Text + "', kategoriAdet='" + txt_kAdet.Text + "' where kategoriID='" + kategoriID + "' ", baglan.baglan());
                cmdkguncelle.ExecuteNonQuery();

                Response.Redirect("kategoriler.aspx");
            }
        }
    }
}