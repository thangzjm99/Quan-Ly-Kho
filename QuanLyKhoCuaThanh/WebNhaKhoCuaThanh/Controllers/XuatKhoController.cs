using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebNhaKhoCuaThanh.Models;

namespace WebNhaKhoCuaThanh.Controllers
{
    public class XuatKhoController : Controller
    {
        // GET: XuatKho/Index
        public ActionResult Index()
        {
            using(DbModels dbModels= new DbModels())
            {
                return View(dbModels.XUATKHOes.ToList());
            }
            
        }

        // GET: XuatKho/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels dbModels = new DbModels())
            {
                return View(dbModels.XUATKHOes.Where(XUATKHO => XUATKHO.MAXUATKHO == id).FirstOrDefault());
            }
            
        }

        // GET: XuatKho/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: XuatKho/Create
        [HttpPost]
        public ActionResult Create(XUATKHO xuatkho)
        {
            try
            {
                using (DbModels dbModels = new DbModels())
                {
                    dbModels.XUATKHOes.Add(xuatkho);
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

        // GET: XuatKho/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels dbModels = new DbModels())
            {
                return View(dbModels.XUATKHOes.Where(XUATKHO => XUATKHO.MAXUATKHO == id).FirstOrDefault());
            }
        }

        // POST: XuatKho/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, XUATKHO xuatkho)
        {
            try
            {
                using (DbModels dbModels = new DbModels())
                {
                    dbModels.Entry(xuatkho).State = EntityState.Modified;
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

        // GET: XuatKho/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels dbModels = new DbModels())
            {
                return View(dbModels.XUATKHOes.Where(XUATKHO => XUATKHO.MAXUATKHO == id).FirstOrDefault());
            }
            return View();
        }

        // POST: XuatKho/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (DbModels dbModels = new DbModels())
                {
                    XUATKHO xuatkho = dbModels.XUATKHOes.Where(XUATKHO => XUATKHO.MAXUATKHO == id).FirstOrDefault();
                    dbModels.XUATKHOes.Remove(xuatkho);
                    dbModels.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
