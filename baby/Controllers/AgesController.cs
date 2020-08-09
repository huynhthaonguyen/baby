using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using baby.Models;

namespace baby.Controllers
{
    public class AgesController : Controller
    {
        private BabyShopEntities db = new BabyShopEntities();

        // GET: Ages
        public ActionResult Index()
        {
            return View(db.Ages.Where(c => c.IsDelete == false));
        }

        // GET: Ages/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Age age = db.Ages.Find(id);
            if (age == null)
            {
                return HttpNotFound();
            }
            return View(age);
        }

        // GET: Ages/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,IsActive,IsDelete")] Age age)
        {
            if (ModelState.IsValid)
            {
                age.CreatedAt = DateTime.Now;  // nhận thời gian hiện tại
                age.UpdatedAt = DateTime.Now;
                db.Ages.Add(age);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(age);
        }

        // GET: Ages/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Age age = db.Ages.Find(id);
            if (age == null)
            {
                return HttpNotFound();
            }
            return View(age);
        }

        // POST: Ages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,IsActive,IsDelete,CreatedAt")] Age age)
        {
            if (ModelState.IsValid)
            {
                age.UpdatedAt = DateTime.Now;
                db.Entry(age).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(age);
        }

        // GET: Ages/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Age age = db.Ages.Find(id);
            if (age == null)
            {
                return HttpNotFound();
            }
            return View(age);
        }

        // POST: Ages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Age age = db.Ages.Find(id);
            db.Ages.Remove(age);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
