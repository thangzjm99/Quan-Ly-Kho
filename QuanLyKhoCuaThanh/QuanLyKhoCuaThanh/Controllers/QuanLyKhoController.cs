using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyKhoCuaThanh.Models;

namespace QuanLyKhoCuaThanh.Controllers
{
    public class QuanLyKhoController : Controller
    {
        // GET: QuanLyKho
        public ActionResult Index()
        {
            using (QuanLyKhoModel quanLyKhoModel = new QuanLyKhoModel())
            {
                return View(quanLyKhoModel.HANGHOAs.ToList());
            }
            return View();
        }

        // GET: QuanLyKho/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QuanLyKho/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuanLyKho/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: QuanLyKho/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QuanLyKho/Edit/5
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

        // GET: QuanLyKho/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QuanLyKho/Delete/5
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
