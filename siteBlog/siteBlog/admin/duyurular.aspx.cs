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
    public partial class duyurular : System.Web.UI.Page
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        string duyurularID = "";
        string islem = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yoneticiKullanici"] == null)
            {
                Response.Redirect("default.aspx"); 
            }

            duyurularID = Request.QueryString["duyurularID"];
            islem = Request.QueryString["islem"];
            if (islem == "sil")
            {
                SqlCommand cmd_dsil = new SqlCommand("delete from Duyurular where duyurularID= '"+duyurularID+"'", baglan.baglan());
                cmd_dsil.ExecuteNonQuery();
            }


            if (Page.IsPostBack == false)
            {
                pnl_duyuruEkle.Visible = true;
                pnl_DuyuruDuzenle.Visible = true;

                //duyuruları getir

                SqlCommand cmd_dgetir = new SqlCommand("Select * from Duyurular", baglan.baglan());
                SqlDataReader dr_dgetir = cmd_dgetir.ExecuteReader();

                datalist_dgetir.DataSource = dr_dgetir;
                datalist_dgetir.DataBind();


            }
        }

        protected void btn_deArti_Click(object sender, EventArgs e)
        {
            pnl_duyuruEkle.Visible = true;
        }

        protected void btn_deEksi_Click(object sender, EventArgs e)
        {
            pnl_duyuruEkle.Visible = false;

        }

        protected void btn_duyuruEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmdduyekle = new SqlCommand("insert into Duyurular (duyurularBaslik,duyurularIcerik,duyurularResim) Values ('" + txt_DuyuruBaslik.Text + "','" + ckeditor.Text + "','/tema/duyurular.png')",baglan.baglan());
            cmdduyekle.ExecuteNonQuery();

            Response.Redirect("duyurular.aspx");
        }

        protected void btn_DuyDuzArti_Click(object sender, EventArgs e)
        {
            pnl_DuyuruDuzenle.Visible = true;
        }

        protected void btn_DuyDuzEksi_Click(object sender, EventArgs e)
        {
            pnl_DuyuruDuzenle.Visible = false;
        }
    }
}