using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamWubWub.Models;

namespace TeamWubWub.Controllers
{
    public class BlogController : Controller
    {
        private TeamWubWubEntities db = new TeamWubWubEntities();

        //
        // GET: /Blog/

        public ActionResult Index()
        {
            return View(db.DroppedBasses.ToList());
        }

        //
        // GET: /Blog/Details/5

        public ActionResult Details(int id = 0)
        {
            DroppedBass droppedbass = db.DroppedBasses.Find(id);
            if (droppedbass == null)
            {
                return HttpNotFound();
            }
            return View(droppedbass);
        }

        //
        // GET: /Blog/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Blog/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DroppedBass droppedbass)
        {
            if (ModelState.IsValid)
            {
                db.DroppedBasses.Add(droppedbass);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(droppedbass);
        }

        //
        // GET: /Blog/Edit/5

        public ActionResult Edit(int id = 0)
        {
            DroppedBass droppedbass = db.DroppedBasses.Find(id);
            if (droppedbass == null)
            {
                return HttpNotFound();
            }
            return View(droppedbass);
        }

        //
        // POST: /Blog/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DroppedBass droppedbass)
        {
            if (ModelState.IsValid)
            {
                db.Entry(droppedbass).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(droppedbass);
        }

        //
        // GET: /Blog/Delete/5

        public ActionResult Delete(int id = 0)
        {
            DroppedBass droppedbass = db.DroppedBasses.Find(id);
            if (droppedbass == null)
            {
                return HttpNotFound();
            }
            return View(droppedbass);
        }

        //
        // POST: /Blog/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DroppedBass droppedbass = db.DroppedBasses.Find(id);
            db.DroppedBasses.Remove(droppedbass);
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