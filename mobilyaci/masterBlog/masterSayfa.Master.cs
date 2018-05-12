using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace masterBlog
{
    public partial class masterSayfa : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        sqlbaglanti bag = new sqlbaglanti();
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmdekle = new SqlCommand("insert into iletisim(iletisimIsim,iletisimEmail,iletisimTel,iletisimMesaj) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox6.Text + "')", bag.baglan());
            cmdekle.ExecuteNonQuery();
            TextBox6.Text = "Mesajınız alınmıştır";
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

            SqlCommand cmd = new SqlCommand("Select * from kullanici where kullaniciEmail='" + TextBox4.Text + "' and kullaniciSifre='" + TextBox5.Text + "'", bag.baglan());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                SqlCommand cmdguncel = new SqlCommand("Select * from kullanici where kullaniciEmail='" + TextBox4.Text + "'", bag.baglan());
                SqlDataReader drguncel = cmdguncel.ExecuteReader();
                DataTable dtguncel = new DataTable("table");
                dtguncel.Load(drguncel);
                DataRow satir = dtguncel.Rows[0];
                Label1.Text = "Hoşgeldin " + satir["kullaniciEmail"].ToString();
            }
            else
            {
                Label1.Text = "Hatalı Giriş";
            }
        }
    }
}