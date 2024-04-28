using Microsoft.AspNetCore.Mvc;

namespace StateManagement.Controllers
{
    public class CookieController : Controller
    {
        public IActionResult SetCookie()
        {
            HttpContext.Response.Cookies.Append("likes", "books");
            HttpContext.Response.Cookies.Append("date", DateTime.Now.ToShortDateString());
            return View();
        }

        public IActionResult GetCookie()
        {
            string? likes = HttpContext.Request.Cookies["likes"];
            string? date = HttpContext.Request.Cookies["date"];

            if(likes is not null && date is not null)
            return Content("user likes " + likes + "\n Date: " + date);
            else
                return RedirectToAction("SetCookie");
        }
    }
}
