using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace deneme
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

       

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            string userName = txtuser.Value;
            string password = txtpass.Value;
            if (userName == "selçuk" && password == "123")
            {
                Response.Redirect("Adminpnl.aspx");
            }
        }
    }
}