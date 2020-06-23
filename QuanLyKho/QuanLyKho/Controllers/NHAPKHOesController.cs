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
    public class NHAPKHOesController : Controller
    {
        private Model1 db = new Model1();

        // GET: NHAPKHOes
        public ActionResult Index()
        {
            var nHAPKHOes = db.NHAPKHOes.Include(n => n.HANGHOA).Include(n => n.NHACUNGCAP);
            return View(nHAPKHOes.ToList());
        }

        // GET: NHAPKHOes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NHAPKHO nHAPKHO = db.NHAPKHOes.Find(id);
            if (nHAPKHO == null)
            {
                return HttpNotFound();
            }
            return View(nHAPKHO);
        }

        // GET: NHAPKHOes/Create
        public ActionResult Create()
        {
            ViewBag.ID_MAHANGHOA = new SelectList(db.HANGHOAs, "MAHANGHOA", "TENHANGHOA");
            ViewBag.ID_MANHACUNGCAP = new SelectList(db.NHACUNGCAPs, "MANHACUNGCAP", "TENNHACUNGCAP");
            return View();
        }

        // POST: NHAPKHOes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MANHAPKHO,NGAYNHAPKHO,ID_MAHANGHOA,ID_MANHACUNGCAP,SOLUONG,DONGIA,THANHTIEN")] NHAPKHO nHAPKHO)
        {
            if (ModelState.IsValid)
            {
                db.NHAPKHOes.Add(nHAPKHO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_MAHANGHOA = new SelectList(db.HANGHOAs, "MAHANGHOA", "TENHANGHOA", nHAPKHO.ID_MAHANGHOA);
            ViewBag.ID_MANHACUNGCAP = new SelectList(db.NHACUNGCAPs, "MANHACUNGCAP", "TENNHACUNGCAP", nHAPKHO.ID_MANHACUNGCAP);
            return View(nHAPKHO);
        }

        // GET: NHAPKHOes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NHAPKHO nHAPKHO = db.NHAPKHOes.Find(id);
            if (nHAPKHO == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_MAHANGHOA = new SelectList(db.HANGHOAs, "MAHANGHOA", "TENHANGHOA", nHAPKHO.ID_MAHANGHOA);
            ViewBag.ID_MANHACUNGCAP = new SelectList(db.NHACUNGCAPs, "MANHACUNGCAP", "TENNHACUNGCAP", nHAPKHO.ID_MANHACUNGCAP);
            return View(nHAPKHO);
        }

        // POST: NHAPKHOes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MANHAPKHO,NGAYNHAPKHO,ID_MAHANGHOA,ID_MANHACUNGCAP,SOLUONG,DONGIA,THANHTIEN")] NHAPKHO nHAPKHO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nHAPKHO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_MAHANGHOA = new SelectList(db.HANGHOAs, "MAHANGHOA", "TENHANGHOA", nHAPKHO.ID_MAHANGHOA);
            ViewBag.ID_MANHACUNGCAP = new SelectList(db.NHACUNGCAPs, "MANHACUNGCAP", "TENNHACUNGCAP", nHAPKHO.ID_MANHACUNGCAP);
            return View(nHAPKHO);
        }

        // GET: NHAPKHOes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NHAPKHO nHAPKHO = db.NHAPKHOes.Find(id);
            if (nHAPKHO == null)
            {
                return HttpNotFound();
            }
            return View(nHAPKHO);
        }

        // POST: NHAPKHOes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NHAPKHO nHAPKHO = db.NHAPKHOes.Find(id);
            db.NHAPKHOes.Remove(nHAPKHO);
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
