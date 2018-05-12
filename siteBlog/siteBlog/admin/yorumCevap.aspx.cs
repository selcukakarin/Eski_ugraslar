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
    public partial class yorumCevap : System.Web.UI.Page
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        string makaleID = "";
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["yoneticiKullanici"]==null)
            {
                Response.Redirect("default.aspx");
            }

        }

        protected void btn_yorumCevap_Click(object sender, EventArgs e)
        {
            makaleID = Request.QueryString["makaleID"];

            SqlCommand cmdYorumEkle = new SqlCommand("insert into Yorum(yorumAdSoyad,yorumIcerik,yorumResim,makaleID) Values ('" + txt_admin.Text + "','" + txt_yorumIcerek.Text + "','/tema/admin.png','" + makaleID + "')", baglan.baglan());
            cmdYorumEkle.ExecuteNonQuery();
            Response.Redirect("yorumlar.aspx");
        }
    }
}