using DemoMVC.Models;
using DemoMVC.Repository;
using DemoMVC.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class MemberController : Controller
    {
        IMemberService _memberService;

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        // GET: Member
        public ActionResult Index()
        {
            var models = _memberService.GetAll();

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
            _memberService.Create(model);

            return RedirectToAction("Index");
        }

        // GET: Member/Edit/5
        public ActionResult Edit(string id)
        {
            var model = _memberService.GetById(id);

            return View(model);
        }

        // POST: Member/Edit/5
        [HttpPost]
        public ActionResult Edit(Member model)
        {
            _memberService.Update(model);

            return RedirectToAction("Index");
        }

        // GET: Member/Delete/5
        public ActionResult Delete(string id)
        {
            _memberService.Delete(id);

            return RedirectToAction("Index");
        }
    }
}
