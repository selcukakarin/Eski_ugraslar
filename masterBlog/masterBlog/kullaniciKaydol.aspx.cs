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
    public partial class kullaniciKaydol : System.Web.UI.Page
    {
        sqlbaglanti bag = new sqlbaglanti();
        
        protected void Page_Load(object sender, EventArgs e)
        {

            

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            SqlCommand kullanicikayit = new SqlCommand("insert into kullanici(kullaniciEmail,kullaniciSifre)values('"+TextBox6.Text+"','"+TextBox7.Text+"')", bag.baglan());
            kullanicikayit.ExecuteNonQuery();
        }
    }
}