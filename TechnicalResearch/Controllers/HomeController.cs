using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechnicalResearch.Models;

namespace TechnicalResearch.Controllers
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ModalTest()
        {
            return View();
        }

        public ActionResult DesignTry()
        {
            return View();
        }

        public ActionResult FormTry()
        {
            return View();
        }

        public ActionResult Test1(Employee[] employees)
        {
            return RedirectToAction("FormTry");
        }

        [HttpPost]
        public ActionResult FormTry(Employee employees)
        {
            if (ModelState.IsValid)
            {
                return View("FormTry");
            }
            else
            {
                return View("FormTry");
            }
        }
    }
}