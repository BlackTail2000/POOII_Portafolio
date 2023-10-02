using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portafolio.Models;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var p = new Persona()
            {
                Nombre = "Gian Franco Pretell",
                Edad = 19
            };

            return View(p);
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