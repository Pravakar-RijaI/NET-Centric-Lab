using EntityFramework.Data;
using EntityFramework.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentDbContext _dbContext;

        public StudentController(StudentDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public IActionResult ReadStudents()
        {
            List<StudentModel> students = _dbContext.Students.ToList();
            return View(students);
        }

        public IActionResult CreateStudents()
        {
            StudentModel student = new StudentModel();
            return View(student);
        }

        [HttpPost]
        public IActionResult CreateStudents(StudentModel student)
        {
            if (student is not null)
            {
                _dbContext.Students.Add(student);
                _dbContext.SaveChanges();
                return RedirectToAction("ReadStudents");
            }
            else
                return View(student);
        }

        public IActionResult UpdateStudents(int studentId)
        {
            StudentModel? student = _dbContext.Students.Find(studentId);

            if (student is not null)
            {
                return View(student);
            }

            else
                return RedirectToAction("ReadStudents");
        }

        [HttpPost]
        public IActionResult UpdateStudents(StudentModel studentModel)
        {
            StudentModel? student = _dbContext.Students.Find(studentModel.StudentId);

            if (student is not null)
            {
                student.Name = studentModel.Name;
                student.Field = studentModel.Field;
                student.Semester = studentModel.Semester;
                student.Marks = studentModel.Marks;
                _dbContext.SaveChanges();
                return RedirectToAction("ReadStudents");
            }
            else
                return View(studentModel);
        }

        public IActionResult DeleteStudents(int studentId)
        {
            StudentModel? student = _dbContext.Students.Find(studentId);

            if (student is not null)
            {
                _dbContext.Students.Remove(student);
                _dbContext.SaveChanges();
            }

            return RedirectToAction("ReadStudents");
        }
    }
}
