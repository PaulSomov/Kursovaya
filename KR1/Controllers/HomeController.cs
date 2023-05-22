using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using KR1.Models;

namespace KR1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationContext _db;

        public HomeController(ApplicationContext context)
        {
            _db = context;
        }

        public IActionResult Index()
        {
            var applications = _db.Applications.ToList();
            return View(applications);
        }

        [HttpGet]
        public IActionResult Create_New_Application()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create_New_Application(Application application)
        {
                application.ApplicationDate = DateTime.Now;
                application.Status = "New";
                _db.Applications.Add(application);
                _db.SaveChanges();
                return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Edit_New_Application(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var application = _db.Applications.Find(id);
            if (application == null)
            {
                return RedirectToAction("Index");
            }

            ViewData["ConfirmEditResult"] = false;
            return View(application);
        }

        [HttpPost]
        public IActionResult Edit_New_Application(int id, bool confirmEditResult)
        {
            var application = _db.Applications.Find(id);
            if (application != null)
            {
                application.Status = confirmEditResult ? "Confirmed" : "Cancel";
                _db.SaveChanges();
            }

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Delete_New_Application(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var application = _db.Applications.Find(id);
            if (application == null)
            {
                return RedirectToAction("Index");
            }

            return View(application);
        }

        [HttpPost]
        public IActionResult Delete_New_Application(int id)
        {
            var application = _db.Applications.Find(id);
            if (application != null)
            {
                _db.Applications.Remove(application);
                _db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
