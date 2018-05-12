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
    public partial class makaleGuncelle : System.Web.UI.Page
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        string makaleID = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yoneticiKullanici"]==null)
            {
                Response.Redirect("default.aspx");
            }

            makaleID = Request.QueryString["makaleID"];
            if (Page.IsPostBack==false)
            {
                SqlCommand cmdmgetir = new SqlCommand("Select * from Makale where makaleID='" + makaleID+"'",baglan.baglan());
                SqlDataReader drmgetir = cmdmgetir.ExecuteReader();

                DataTable dtmakalegetir = new DataTable("tablo");
                dtmakalegetir.Load(drmgetir);

                DataRow row = dtmakalegetir.Rows[0];
                txt_MBaslik.Text = row["makaleBaslik"].ToString();
                txt_MOzet.Text = row["makaleOzet"].ToString();
                txt_ckmguncelle.Text = row["makaleIcerik"].ToString();
                txt_YorumSay.Text = row["makaleYorumSayisi"].ToString();

            }

        }

        protected void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (fu_slider.HasFile)
            {
                fu_slider.SaveAs(Server.MapPath("/sresim/" + fu_slider.FileName));

                SqlCommand cmdmguncelle = new SqlCommand("Update Makale Set  makaleBaslik='"+txt_MBaslik.Text+"',makaleOzet'"+txt_MOzet.Text+"',makaleIcerik='"+txt_ckmguncelle.Text+"',makaleResim='/sresim/"+fu_slider.FileName+"',makaleYorumSayisi='"+txt_YorumSay.Text+"' where makaleID='"+makaleID+"'",baglan.baglan());
                cmdmguncelle.ExecuteNonQuery();

                Response.Redirect("makaleler.aspx");


            }
            else
            {
                SqlCommand cmdmguncelle2 = new SqlCommand("Update Makale Set makaleBaslik='" + txt_MBaslik.Text + "',makaleOzet='" + txt_MOzet.Text + "',makaleIcerik='" + txt_ckmguncelle.Text + "',makaleYorumSayisi='" + txt_YorumSay.Text + "'where makaleID='" + makaleID + "'", baglan.baglan());
                cmdmguncelle2.ExecuteNonQuery();
                Response.Redirect("makaleler.aspx");
            }
        }
    }
}