using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcSmartphone.Models;

namespace MvcSmartphone.Controllers
{
    public class SmartPhoneController : Controller
    {
        private SmartPhoneDBContext db = new SmartPhoneDBContext();

        //
        // GET: /SmartPhone/

        public ActionResult Index()
        {
            return View(db.SmartPhone.ToList());
        }

        //
        // GET: /SmartPhone/Details/5

        public ActionResult Details(int id = 0)
        {
            SmartPhone smartphone = db.SmartPhone.Find(id);
            if (smartphone == null)
            {
                return HttpNotFound();
            }
            return View(smartphone);
        }

        //
        // GET: /SmartPhone/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /SmartPhone/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SmartPhone smartphone)
        {
            if (ModelState.IsValid)
            {
                db.SmartPhone.Add(smartphone);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(smartphone);
        }

        //
        // GET: /SmartPhone/Edit/5

        public ActionResult Edit(int id = 0)
        {
            SmartPhone smartphone = db.SmartPhone.Find(id);
            if (smartphone == null)
            {
                return HttpNotFound();
            }
            return View(smartphone);
        }

        //
        // POST: /SmartPhone/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SmartPhone smartphone)
        {
            if (ModelState.IsValid)
            {
                db.Entry(smartphone).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(smartphone);
        }

        //
        // GET: /SmartPhone/Delete/5

        public ActionResult Delete(int id = 0)
        {
            SmartPhone smartphone = db.SmartPhone.Find(id);
            if (smartphone == null)
            {
                return HttpNotFound();
            }
            return View(smartphone);
        }

        //
        // POST: /SmartPhone/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SmartPhone smartphone = db.SmartPhone.Find(id);
            db.SmartPhone.Remove(smartphone);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}