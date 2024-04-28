using CollegeWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CollegeWebApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Students(int id)
        {
            List<StudentModel> students = new List<StudentModel>
            {new StudentModel{SchoolId = id, RegistrationNumber = 30 ,Name = "Pravakar Rijal", Email = "pravakarrijal@gmail.com"  },
            new StudentModel{SchoolId = id, RegistrationNumber = 21 ,Name = "Manish Dhungana", Email = "manishdhungana@gmail.com"  } };

            return View(students);
        }
        public IActionResult StudentForm()
        {
            StudentModel studentModel = new StudentModel();
            return View(studentModel);
        }

        [HttpPost]
        public IActionResult StudentForm(StudentModel student)
        {
            if (ModelState.IsValid)
                return View(student);

            return View(student);
        }


    }
}
