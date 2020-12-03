using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using planerApp.Models;
using System.Data.Entity;

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
                var tassks = db.Tassks;
                ViewBag.Tassks = tassks;
                var events = db.Events;
                ViewBag.Events = events;
                return View(notates); 
            }
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Notate notate)
        {
            db.Notates.Add(notate);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Notate n = db.Notates.Find(id);
            if (n == null)
            {
                return HttpNotFound();
            }
            return View(n);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Notate n = db.Notates.Find(id);
            if (n == null)
            {
                return HttpNotFound();
            }
            db.Notates.Remove(n);
            db.SaveChanges();
            return RedirectToAction("Index");
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