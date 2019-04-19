using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NDCShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Assortment()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult SignIn()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}