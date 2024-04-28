using ClientSideValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClientSideValidation.Controllers
{
    public class StudentContactController : Controller
    {
        [HttpGet]
        public IActionResult ContactForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactForm(StudentModel student)
        {
            string output = "Dear, " + student.Name + "\nDetails Submitted Successfully...\n";
            return Content(output);
        }
    }
}
