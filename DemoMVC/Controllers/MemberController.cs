using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class MemberController : Controller
    {
        readonly MyContext db = new MyContext();

        // GET: Member
        public ActionResult Index()
        {   
            var models = db.Members.ToList();

            return View(models);
        }

        // GET: Member/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Member/Create
        [HttpPost]
        public ActionResult Create(Member model)
        {
            db.Members.Add(model);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Member/Edit/5
        public ActionResult Edit(string id)
        {
            var model = db.Members.Find(id);

            return View(model);
        }

        // POST: Member/Edit/5
        [HttpPost]
        public ActionResult Edit(Member model)
        {
            db.Entry(model).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Member/Delete/5
        public ActionResult Delete(string id)
        {
            var model = db.Members.Find(id);
            db.Members.Remove(model);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
