using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Piparwar.com.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Welcome - PiparwarWeb.com";
            return View();
        }

        public ActionResult AboutUs()
        {
            ViewBag.Title = "About Us - Piparwar.com";
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Portfolio()
        {
            return View();
        }

        public ActionResult Team()
        {
            return View();
        }

        public ActionResult Dropdown()
        {
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}