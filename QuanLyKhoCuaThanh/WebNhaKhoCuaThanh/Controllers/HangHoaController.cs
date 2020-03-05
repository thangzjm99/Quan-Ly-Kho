using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebNhaKhoCuaThanh.Models;

namespace WebNhaKhoCuaThanh.Controllers
{
    public class HangHoaController : Controller
    {
        // GET: HangHoa/index
        public ActionResult Index()
        {
            using (DbModels dbModels = new DbModels())
            {
                return View(dbModels.HANGHOAs.ToList());
            }
            
        }

        // GET: HangHoa/Details/5
        public ActionResult Details(int id)
        {
           using (DbModels dbModels = new DbModels())
            {
                return View(dbModels.HANGHOAs.Where(HANGHOA => HANGHOA.MAHANGHOA == id).FirstOrDefault());
            }
        }

        // GET: HangHoa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HangHoa/Create
        [HttpPost]
        public ActionResult Create(HANGHOA hanghoa)
        {
            try
            {
                using (DbModels dbModels = new DbModels())
                {
                    dbModels.HANGHOAs.Add(hanghoa);
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

        // GET: HangHoa/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels dbModels = new DbModels())
            {
                return View(dbModels.HANGHOAs.Where(HANGHOA => HANGHOA.MAHANGHOA == id).FirstOrDefault());
            }
        }

        // POST: HangHoa/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, HANGHOA hanghoa)
        {
            try
            {
                using (DbModels dbModels = new DbModels())
                {
                    dbModels.Entry(hanghoa).State = EntityState.Modified;
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

        // GET: HangHoa/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels dbModels = new DbModels())
            {
                return View(dbModels.HANGHOAs.Where(HANGHOA => HANGHOA.MAHANGHOA == id).FirstOrDefault());
            }
        }

        // POST: HangHoa/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (DbModels dbModels= new DbModels())
                {
                    HANGHOA hanghoa = dbModels.HANGHOAs.Where(HANGHOA => HANGHOA.MAHANGHOA == id).FirstOrDefault();
                    dbModels.HANGHOAs.Remove(hanghoa);
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
