using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using System.Windows;

namespace QuanLyKho.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login()
        {
            string user = Request.Form["Usernametext"];
            string password = Request.Form["Passwordtext"];
            if (user == "admin" && password == "admin")
            {
                return RedirectToAction("Index","Home",null);
            }
            else
            {
                MessageBox.Show("wrong id or password");

                return RedirectToAction("Index", "Login", null);
            }
        }
    }
}