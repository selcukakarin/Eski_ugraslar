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
    public partial class duyuruguncelle : System.Web.UI.Page
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        string duyurularID = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yoneticiKullanici"] == null)
            {
                Response.Redirect("default.aspx");
            }


            duyurularID = Request.QueryString["duyurularID"];
            if (Page.IsPostBack == false)
            {
                SqlCommand cmd_dgetir = new SqlCommand("Select * from Duyurular where duyurularID='"+duyurularID+"'", baglan.baglan());
                SqlDataReader dr_dgetir = cmd_dgetir.ExecuteReader();

                DataTable dt_dgetir = new DataTable("tablo");
                dt_dgetir.Load(dr_dgetir);

                DataRow row = dt_dgetir.Rows[0];
                txt_duyuruBaslik.Text = row["duyurularBaslik"].ToString();
                txt_DuyuruIcerik.Text = row["duyurularIcerik"].ToString();


            }
        }

        protected void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd_dguncelle = new SqlCommand("Update Duyurular set duyurularBaslik='"+txt_duyuruBaslik.Text+"',duyurularIcerik='"+txt_DuyuruIcerik.Text+"' where  duyurularID='"+duyurularID+"'", baglan.baglan());
            cmd_dguncelle.ExecuteNonQuery();

            Response.Redirect("duyurular.aspx");
        }
    }
}