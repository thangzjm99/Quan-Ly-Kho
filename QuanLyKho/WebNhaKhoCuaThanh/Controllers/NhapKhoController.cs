using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebNhaKhoCuaThanh.Models;

namespace WebNhaKhoCuaThanh.Controllers
{
    public class NhapKhoController : Controller
    {
        // GET: NhapKho
        public ActionResult Index()
        {
            using (DbModels dbModels = new DbModels())
            {
                return View(dbModels.NHAPKHOes.ToList());
            }
        }

        // GET: NhapKho/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels dbModels = new DbModels())
            {
                return View(dbModels.NHAPKHOes.Where(NHAPKHO => NHAPKHO.MANHAPKHO == id).FirstOrDefault());
            }
        }

        // GET: NhapKho/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhapKho/Create
        [HttpPost]
        public ActionResult Create(NHAPKHO nhapkho)
        {
            try
            {
                using (DbModels dbModels = new DbModels())
                {
                    dbModels.NHAPKHOes.Add(nhapkho);
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

        // GET: NhapKho/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels dbModels = new DbModels())
            {
                return View(dbModels.NHAPKHOes.Where(NHAPKHO => NHAPKHO.MANHAPKHO == id).FirstOrDefault());
            }
        }

        // POST: NhapKho/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, NHAPKHO nhapkho)
        {
            try
            {
                using (DbModels dbModels = new DbModels())
                {
                    dbModels.Entry(nhapkho).State = EntityState.Modified;
                    dbModels.SaveChanges();
                }
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhapKho/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels dbModels = new DbModels())
            {
                return View(dbModels.NHAPKHOes.Where(NHAPKHO => NHAPKHO.MANHAPKHO == id).FirstOrDefault());
            }
        }

        // POST: NhapKho/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (DbModels dbModels = new DbModels())
                {
                    NHAPKHO nhapkho = dbModels.NHAPKHOes.Where(NHAPKHO => NHAPKHO.MANHAPKHO == id).FirstOrDefault();
                    dbModels.NHAPKHOes.Remove(nhapkho);
                    dbModels.SaveChanges();
                }
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
