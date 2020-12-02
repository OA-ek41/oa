using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using planerApp.Models;

namespace planerApp.Controllers
{
    public class HomeController : Controller
    {
        NotateContext db = new NotateContext();
        public ActionResult Index()        
        {
            {
                var notates = db.Notates;
                ViewBag.Notates = notates;
                return View(); 
            }
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