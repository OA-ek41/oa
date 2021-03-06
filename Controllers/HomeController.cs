﻿using System;
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
        [HttpGet]
        public ActionResult ChangeN(int id)
        {
            Notate n = db.Notates.Find(id);
            if (n == null)
            {
                return HttpNotFound();
            }
            var notates = db.Notates;
            ViewBag.Notates = notates;
            return View(n);
        }
        [HttpPost, ActionName("ChangeN")]
        public ActionResult ChangeNConfirmed(int id, Notate notate)
        {
            Notate n = db.Notates.Find(id);
            if (n == null)
            {
                return HttpNotFound();
            }
            db.Notates.Remove(n);
            db.Notates.Add(notate);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateE()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateE(Event events)
        {
            db.Events.Add(events);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DeleteE(int e_id)
        {
            Event n = db.Events.Find(e_id);
            if (n == null)
            {
                return HttpNotFound();
            }
            return View(n);
        }
        [HttpPost, ActionName("DeleteE")]
        public ActionResult DeleteEConfirmed(int e_id)
        {
            Event n = db.Events.Find(e_id);
            if (n == null)
            {
                return HttpNotFound();
            }
            db.Events.Remove(n);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult ChangeE(int e_id)
        {
            Event n = db.Events.Find(e_id);
            if (n == null)
            {
                return HttpNotFound();
            }
            var eventt = db.Events;
            ViewBag.Events = eventt;
            return View(n);
        }
        [HttpPost, ActionName("ChangeE")]
        public ActionResult ChangeEConfirmed(int e_id, Event eventt)
        {
            Event n = db.Events.Find(e_id);
            if (n == null)
            {
                return HttpNotFound();
            }
            db.Events.Remove(n);
            db.Events.Add(eventt);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        
         [HttpGet]
        public ActionResult CreateT()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult CreateT(Tassk tassk)
        {
            tassk.T_check = false;
            db.Tassks.Add(tassk);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public ActionResult DeleteT(int TaskId)
        {
            Tassk n = db.Tassks.Find(TaskId);
            if (n == null)
            {
                return HttpNotFound();
            }
            return View(n);
        }
        
        [HttpPost, ActionName("DeleteT")]
        public ActionResult DeleteTConfirmed(int TaskId)
        {
            Tassk n = db.Tassks.Find(TaskId);
            if (n == null)
            {
                return HttpNotFound();
            }
            db.Tassks.Remove(n);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public ActionResult ChangeT(int TaskId)
        {
            Tassk n = db.Tassks.Find(TaskId);
            if (n == null)
            {
                return HttpNotFound();
            }
            var tassk = db.Tassks;
            ViewBag.Events = tassk;
            return View(n);
        }
        [HttpPost, ActionName("ChangeE")]
        public ActionResult ChangeEConfirmed(int TaskId, Tassk tassk)
        {
            Tassk n = db.Tassks.Find(TaskId);
            if (n == null)
            {
                return HttpNotFound();
            }
            db.Tassks.Remove(n);
            db.Tassks.Add(tassk);
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