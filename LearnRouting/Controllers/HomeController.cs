using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnRouting.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult SecondAction(string secondparm)
        {
             return View();
        }

        public ActionResult FirstAction(string param)
        {
            ViewBag.Message = "My page.";

            return View("Contact");
        }
    }
}