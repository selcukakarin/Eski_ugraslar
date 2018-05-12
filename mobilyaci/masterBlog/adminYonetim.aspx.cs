using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace masterYonetim
{
    public partial class adminYonetim : System.Web.UI.Page
    {
        sqlbaglanti bag = new sqlbaglanti();
        string urunID = "";
        string islem = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            urunID = Request.QueryString["urunID"];
            islem = Request.QueryString["islem"];
            if (islem == "sil")
            {
                SqlCommand cmdsil = new SqlCommand("delete from urun where urunID='" + urunID + "'  ", bag.baglan());
                cmdsil.ExecuteNonQuery();
            }

            if (Page.IsPostBack == false)
            {
                urunekle.Visible = true;
                urunguncelle.Visible = true;
            }

            SqlCommand cmdgetir = new SqlCommand("Select * from urun", bag.baglan());
            SqlDataReader drgetir = cmdgetir.ExecuteReader();

            DataList1.DataSource = drgetir;
            DataList1.DataBind();
        }

        protected void arti_Click(object sender, EventArgs e)
        {
            urunekle.Visible = true;
        }

        protected void eksi_Click(object sender, EventArgs e)
        {
            urunekle.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string uzanti = System.IO.Path.GetExtension(FileUpload1.FileName);
                if (uzanti == ".png" || uzanti == ".jpg" || uzanti == ".jpeg")
                {
                    string yol = Server.MapPath("~/urunresim/");
                    FileUpload1.SaveAs(yol +urunID+  uzanti);
                    SqlCommand cmdekle = new SqlCommand("insert into urun(urunBaslik,urunIcerik,urunOzet,urunResim) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + urunID + uzanti + "')", bag.baglan());
                    cmdekle.ExecuteNonQuery();

                    Response.Redirect("adminYonetim.aspx");
                }
            }
            else
            {
                Label1.Text = "Resim Ekle !!!";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            urunguncelle.Visible = true;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            urunguncelle.Visible = false;
        }
    }
}