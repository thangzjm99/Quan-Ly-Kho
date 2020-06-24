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
    public class XUATKHOesController : Controller
    {
        private Model1 db = new Model1();

        // GET: XUATKHOes
        public ActionResult Index()
        {
            var xUATKHOes = db.XUATKHOes.Include(x => x.HANGHOA);
            return View(xUATKHOes.ToList());
        }

        // GET: XUATKHOes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            XUATKHO xUATKHO = db.XUATKHOes.Find(id);
            if (xUATKHO == null)
            {
                return HttpNotFound();
            }
            return View(xUATKHO);
        }

        // GET: XUATKHOes/Create
        public ActionResult Create()
        {
            ViewBag.ID_MAHANGHOA = new SelectList(db.HANGHOAs, "MAHANGHOA", "TENHANGHOA");
            return View();
        }

        // POST: XUATKHOes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MAXUATKHO,NGAYXUATKHO,ID_MAHANGHOA,SOLUONG,DONGIA,THANHTIEN")] XUATKHO xUATKHO)
        {
            if (ModelState.IsValid)
            {
                db.XUATKHOes.Add(xUATKHO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_MAHANGHOA = new SelectList(db.HANGHOAs, "MAHANGHOA", "TENHANGHOA", xUATKHO.ID_MAHANGHOA);
            return View(xUATKHO);
        }

        // GET: XUATKHOes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            XUATKHO xUATKHO = db.XUATKHOes.Find(id);
            if (xUATKHO == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_MAHANGHOA = new SelectList(db.HANGHOAs, "MAHANGHOA", "TENHANGHOA", xUATKHO.ID_MAHANGHOA);
            return View(xUATKHO);
        }

        // POST: XUATKHOes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MAXUATKHO,NGAYXUATKHO,ID_MAHANGHOA,SOLUONG,DONGIA,THANHTIEN")] XUATKHO xUATKHO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(xUATKHO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_MAHANGHOA = new SelectList(db.HANGHOAs, "MAHANGHOA", "TENHANGHOA", xUATKHO.ID_MAHANGHOA);
            return View(xUATKHO);
        }

        // GET: XUATKHOes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            XUATKHO xUATKHO = db.XUATKHOes.Find(id);
            if (xUATKHO == null)
            {
                return HttpNotFound();
            }
            return View(xUATKHO);
        }

        // POST: XUATKHOes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            XUATKHO xUATKHO = db.XUATKHOes.Find(id);
            db.XUATKHOes.Remove(xUATKHO);
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
