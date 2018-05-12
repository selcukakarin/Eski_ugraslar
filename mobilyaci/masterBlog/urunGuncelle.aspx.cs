using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace masterYonetim
{
    public partial class urunGuncelle : System.Web.UI.Page
    {
        sqlbaglanti bag = new sqlbaglanti();
        string urunID = "";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            urunID = Request.QueryString["urunID"];

            if (Page.IsPostBack == false)
            {
                SqlCommand cmdguncel = new SqlCommand("Select * from urun where urunID='" + urunID + "'", bag.baglan());
                SqlDataReader drguncel = cmdguncel.ExecuteReader();
                DataTable dtguncel = new DataTable("table");
                dtguncel.Load(drguncel);
                DataRow satir = dtguncel.Rows[0];
                TextBox1.Text = satir["urunBaslik"].ToString();
                TextBox2.Text = satir["urunIcerik"].ToString();
                TextBox3.Text = satir["urunOzet"].ToString();


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string uzanti = System.IO.Path.GetExtension(FileUpload1.FileName);
                if (uzanti == ".png" || uzanti == ".jpg" || uzanti == ".jpeg")
                {
                    string yol = Server.MapPath("~/urunresim/");
                    FileUpload1.SaveAs(yol +urunID+ uzanti);
                    SqlCommand cmdekle = new SqlCommand("update urun set urunBaslik = '" + TextBox1.Text + "', urunIcerik = '" + TextBox2.Text + "', urunOzet = '" + TextBox3.Text + "',urunResim='" + urunID + uzanti+"' where urunID = '" + urunID + "'", bag.baglan());
                    cmdekle.ExecuteNonQuery();
                    Response.Redirect("adminYonetim.aspx");
                }
            }
            else
            {
                
                    SqlCommand komutguncel1 = new SqlCommand("update urun set urunBaslik='" + TextBox1.Text + "',urunIcerik='" + TextBox2.Text + "',urunOzet='" + TextBox3.Text + "' where urunID='" + urunID + "'", bag.baglan());
                    komutguncel1.ExecuteNonQuery();
                    Response.Redirect("adminYonetim.aspx");
                
            }
        }
    }
}