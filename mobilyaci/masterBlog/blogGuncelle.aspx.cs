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
    public partial class blogGuncelle : System.Web.UI.Page
    {
        sqlbaglanti bag = new sqlbaglanti();
        string blogID = "";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            blogID = Request.QueryString["blogID"];

            if (Page.IsPostBack == false)
            {
                SqlCommand cmdguncel = new SqlCommand("Select * from blog where blogID='" + blogID + "'", bag.baglan());
                SqlDataReader drguncel = cmdguncel.ExecuteReader();
                DataTable dtguncel = new DataTable("table");
                dtguncel.Load(drguncel);
                DataRow satir = dtguncel.Rows[0];
                TextBox1.Text = satir["blogBaslik"].ToString();
                TextBox2.Text = satir["blogIcerik"].ToString();
                TextBox3.Text = satir["blogOzet"].ToString();


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string uzanti = System.IO.Path.GetExtension(FileUpload1.FileName);
                if (uzanti == ".png" || uzanti == ".jpg" || uzanti == ".jpeg")
                {
                    string yol = Server.MapPath("~/blogresim/");
                    FileUpload1.SaveAs(yol + blogID + uzanti);
                    SqlCommand cmdekle = new SqlCommand("update blog set blogBaslik = '" + TextBox1.Text + "', blogIcerik = '" + TextBox2.Text + "', blogOzet = '" + TextBox3.Text + "',blogResim='" + FileUpload1.FileName  +"' where blogID = '" + blogID + "'", bag.baglan());
                    cmdekle.ExecuteNonQuery();
                    Response.Redirect("adminBlog.aspx");
                }
            }
            else
            {
                
                    SqlCommand komutguncel1 = new SqlCommand("update blog set blogBaslik='" + TextBox1.Text + "',blogIcerik='" + TextBox2.Text + "',blogOzet='" + TextBox3.Text + "' where blogID='" + blogID + "'", bag.baglan());
                    komutguncel1.ExecuteNonQuery();
                    Response.Redirect("adminBlog.aspx");
                
            }
        }
    }
}