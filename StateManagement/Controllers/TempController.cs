using Microsoft.AspNetCore.Mvc;

namespace StateManagement.Controllers
{
    public class TempController : Controller
    {
        public IActionResult FirstPage()
        {
            TempData["UserId"] = 101;
            HttpContext.Session.SetString("username", "kelvin malone");
            ViewBag.Username = HttpContext.Session.GetString("username");
            ViewData["Date"] = DateTime.Now.ToShortDateString();
            return View();
        }

        public IActionResult SecondPage()
        {
            ViewBag.Username = HttpContext.Session.GetString("username");
            return View();
        }
    }
}
