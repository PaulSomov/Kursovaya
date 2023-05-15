using System.Linq;
using Microsoft.AspNetCore.Mvc;
using KR1.Models;
 
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
    }
}