using ProjMVCEF.Dal;
using ProjMVCEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjMVCEF.Controllers
{
    public class DogController : Controller
    {
        private DogContext db = new DogContext();

        // GET: Dog
        public ActionResult Index()
        {
            return View(db.Dogs.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Dog dog)
        {
            if (ModelState.IsValid)
            {
                db.Dogs.Add(dog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dog);
        }

        public ActionResult Edit(int id)
        {
            return View(db.Dogs.First(d => d.Id == id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Dog dog)
        {
            if (ModelState.IsValid)
            {
                Dog dogUpdate = db.Dogs.First(d => d.Id == dog.Id);
                dogUpdate.Name = dog.Name;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dog);
        }

        public ActionResult Details(int id)
        {
            return View(db.Dogs.First(d => d.Id == id));
        }

        public ActionResult Delete(int id)
        {
            return View(db.Dogs.First(d => d.Id == id));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            var dog = db.Dogs.First(d => d.Id == id);
            db.Dogs.Remove(dog);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}