using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DapperUi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Index","Stud");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View("Search","Stud");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "My Student List";

            return RedirectToAction("StudTable","Stud");
        }
        public ActionResult Ret()
        {
            ViewBag.Message = "My Student List";

            return RedirectToAction("OutputReturn", "Stud");
        }
    }
}