using Microsoft.AspNetCore.Mvc;

namespace CollegeWebApp.Controllers
{
    public class HomeController : Controller
    { 
        public IActionResult Index()
        {
            return View();
        }
    }
}
