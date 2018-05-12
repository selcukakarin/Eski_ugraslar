using FormExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormExample.Controllers
{
    public class FormExample1Controller : Controller
    {
        //
        // GET: /FormExample1/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            FormExampleDBEntities db = new FormExampleDBEntities();
            Users model = new Users();
            model.City = form["City"].Trim();
            model.UserName = form["UserName"].Trim();
            model.UserSurName = form["UserSurName"].Trim();
            db.Users.Add(model);
            db.SaveChanges();
            
            return View();
            
        }

    }
}
