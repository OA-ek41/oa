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
                var tassk = db.Tassks;
                ViewBag.Tassks = tassk;
                return View(); 
            }
        }
        [HttpGet]
        public ActionResult Change()
        {
            return View();
        }

        [HttpPost]
        public string Change(Notate notate)
        {
            db.Notates.Add(notate);
            db.SaveChanges();
            return ("Note" + notate.title + "was added");
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