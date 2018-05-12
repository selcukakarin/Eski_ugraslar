using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace instagram_css.Controllers
{
    public class LogInController : Controller
    {
        //
        // GET: /LogIn/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginForm(FormCollection from)
        {
            string userName = form["UserName"].Trim();
            string password = form["Password"].Trim();

            if (userName == "yildirim" && password == "123")
            {
                Session["Admin"] = "1";
                return Redirect("~/Video");
            }
            return View("Index");
        }

    }
}
