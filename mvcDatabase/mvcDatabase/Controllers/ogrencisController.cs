using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using mvcDatabase;

namespace mvcDatabase.Controllers
{
    public class ogrencisController : Controller
    {
        private OgrenciBilgiEntities db = new OgrenciBilgiEntities();

        // GET: ogrencis
        public ActionResult Index()
        {
            var ogrenci = db.ogrenci.Include(o => o.ders);
            return View(ogrenci.ToList());
        }

        // GET: ogrencis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ogrenci ogrenci = db.ogrenci.Find(id);
            if (ogrenci == null)
            {
                return HttpNotFound();
            }
            return View(ogrenci);
        }

        // GET: ogrencis/Create
        public ActionResult Create()
        {
            ViewBag.ders_ID = new SelectList(db.ders, "ders_ID", "ders_adi");
            return View();
        }

        // POST: ogrencis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ogrenci_ID,ad_soyad,ders_ID")] ogrenci ogrenci)
        {
            if (ModelState.IsValid)
            {
                db.ogrenci.Add(ogrenci);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ders_ID = new SelectList(db.ders, "ders_ID", "ders_adi", ogrenci.ders_ID);
            return View(ogrenci);
        }

        // GET: ogrencis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ogrenci ogrenci = db.ogrenci.Find(id);
            if (ogrenci == null)
            {
                return HttpNotFound();
            }
            ViewBag.ders_ID = new SelectList(db.ders, "ders_ID", "ders_adi", ogrenci.ders_ID);
            return View(ogrenci);
        }

        // POST: ogrencis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ogrenci_ID,ad_soyad,ders_ID")] ogrenci ogrenci)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ogrenci).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ders_ID = new SelectList(db.ders, "ders_ID", "ders_adi", ogrenci.ders_ID);
            return View(ogrenci);
        }

        // GET: ogrencis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ogrenci ogrenci = db.ogrenci.Find(id);
            if (ogrenci == null)
            {
                return HttpNotFound();
            }
            return View(ogrenci);
        }

        // POST: ogrencis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ogrenci ogrenci = db.ogrenci.Find(id);
            db.ogrenci.Remove(ogrenci);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
