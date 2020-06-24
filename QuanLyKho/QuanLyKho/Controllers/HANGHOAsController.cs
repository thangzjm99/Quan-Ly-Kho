using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuanLyKho.Models;

namespace QuanLyKho.Controllers
{
    public class HANGHOAsController : Controller
    {
        private Model1 db = new Model1();

        // GET: HANGHOAs
        public ActionResult Index()
        {
            return View(db.HANGHOAs.ToList());
        }

        // GET: HANGHOAs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HANGHOA hANGHOA = db.HANGHOAs.Find(id);
            if (hANGHOA == null)
            {
                return HttpNotFound();
            }
            return View(hANGHOA);
        }

        // GET: HANGHOAs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HANGHOAs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MAHANGHOA,TENHANGHOA,XUATXU,DONGIA,SOLUONGSANSANG")] HANGHOA hANGHOA)
        {
            if (ModelState.IsValid)
            {
                db.HANGHOAs.Add(hANGHOA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hANGHOA);
        }

        // GET: HANGHOAs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HANGHOA hANGHOA = db.HANGHOAs.Find(id);
            if (hANGHOA == null)
            {
                return HttpNotFound();
            }
            return View(hANGHOA);
        }

        // POST: HANGHOAs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MAHANGHOA,TENHANGHOA,XUATXU,DONGIA,SOLUONGSANSANG")] HANGHOA hANGHOA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hANGHOA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hANGHOA);
        }

        // GET: HANGHOAs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HANGHOA hANGHOA = db.HANGHOAs.Find(id);
            if (hANGHOA == null)
            {
                return HttpNotFound();
            }
            return View(hANGHOA);
        }

        // POST: HANGHOAs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HANGHOA hANGHOA = db.HANGHOAs.Find(id);
            db.HANGHOAs.Remove(hANGHOA);
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
