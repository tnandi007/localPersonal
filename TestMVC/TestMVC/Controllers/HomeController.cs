using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestAPI;

namespace TestMVC.Controllers
{
    public class HomeController : AsyncController
    {
        //[AllowAnonymous]
        public ActionResult Index()
        {
            //return Json("Hello there..");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}