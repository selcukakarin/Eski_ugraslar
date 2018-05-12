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
    public partial class iletisim : System.Web.UI.Page
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_YorumEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmdEkle = new SqlCommand("insert into Iletisim(iletisimAdSoyad,iletisimEmail,iletisimIcerik) Values ('" + txt_AdSoyad.Text + "','" + txt_Email.Text + "','" + txt_yorumIcerik.Text + "')", baglan.baglan());
            cmdEkle.ExecuteNonQuery();

            txt_AdSoyad.Text = "";
            txt_Email.Text = "";
            txt_yorumIcerik.Text = "";
            lbl_bilgi.Text = "Mesajınız alındı";
        }
    }
}