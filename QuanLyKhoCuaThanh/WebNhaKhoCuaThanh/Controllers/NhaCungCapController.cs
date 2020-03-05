using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebNhaKhoCuaThanh.Models;

namespace WebNhaKhoCuaThanh.Controllers
{
    public class NhaCungCapController : Controller
    {
        // GET: NhaCungCap
        public ActionResult Index()
        {
            using(DbModels dbModels = new DbModels())
            {
                return View(dbModels.NHACUNGCAPs.ToList());
            }
        }

        // GET: NhaCungCap/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels dbModels = new DbModels())
            {
                return View(dbModels.NHACUNGCAPs.Where(NHACUNGCAP => NHACUNGCAP.MANHACUNGCAP == id).FirstOrDefault());
            }
        }

        // GET: NhaCungCap/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhaCungCap/Create
        [HttpPost]
        public ActionResult Create(NHACUNGCAP nhacungcap)
        {
            try
            {
                using (DbModels dbModels = new DbModels())
                {
                    dbModels.NHACUNGCAPs.Add(nhacungcap);
                    dbModels.SaveChanges();
                }
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhaCungCap/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels dbModels = new DbModels())
            {
                return View(dbModels.NHACUNGCAPs.Where(NHACUNGCAP => NHACUNGCAP.MANHACUNGCAP == id).FirstOrDefault());
            }
        }

        // POST: NhaCungCap/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhaCungCap/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NhaCungCap/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
