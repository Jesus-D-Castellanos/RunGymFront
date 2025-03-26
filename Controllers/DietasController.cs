using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RunGymFront.Controllers
{
    public class DietasController : Controller
    {
        public ActionResult Keto()
        {
            return View();
        }

        public ActionResult Mediterranea()
        {
            return View();
        }

        public ActionResult Vegetariana()
        {
            return View();
        }
    }
}
