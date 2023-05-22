using System.Linq;
using Microsoft.AspNetCore.Mvc;
using KR1.Models;
using System.ComponentModel.DataAnnotations;

namespace KR1.Controllers
{
    public class HomeController : Controller
    {
        ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Applications.ToList());
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
            db.Applications.Add(application);
            db.SaveChanges();
            return Redirect("/Home/Index/");
        }

        private void Alert(string v)
        {
            throw new NotImplementedException(v);
        }

        public enum TimeOfDay
        {
            [Display(Name = "Утро")]
            Morning,
            [Display(Name = "День")]
            Afternoon,
            [Display(Name = "Вечер")]
            Evening,
            [Display(Name = "Ночь")]
            Night
        }
    }
}
