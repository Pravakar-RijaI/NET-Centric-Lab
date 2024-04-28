using Microsoft.AspNetCore.Mvc;
using StateManagement.Models;

namespace StateManagement.Controllers
{
    public class StateController : Controller
    {
        public IActionResult SetSession()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetSession(UserModel user)
        {
            if (user.username is not null)
            {
                HttpContext.Session.SetString("username", user.username);
                string? Username = HttpContext.Session.GetString("username");
                return View("GetSession",Username);
            }
            else
                return RedirectToAction("SetSession");
        }
    }
}
