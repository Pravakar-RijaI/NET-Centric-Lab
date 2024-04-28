using ADO.NET.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace ADO.NET.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult DisplayStudent()
        {
            try
            {
                List<StudentModel> Students = new List<StudentModel>();

                string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=Pravakardb;Integrated Security=True;Encrypt=False;";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string command = "Select * From Student";
                SqlCommand sqlCommand = new SqlCommand(command, conn);
                //sqlCommand.ExecuteReader();

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow student in dataTable.Rows)
                {
                    StudentModel studentModel = new StudentModel();
                    studentModel.Id = Convert.ToInt32(student["Id"]);
                    studentModel.Name = student["Name"].ToString();
                    studentModel.Field = student["Field"].ToString();
                    studentModel.Semester = Convert.ToInt32(student["Semester"]);
                    studentModel.Marks = Convert.ToDecimal(student["Marks"]);
                    Students.Add(studentModel);
                }
                return View(Students);
            }
            catch (Exception e)
            {
                return Content("Technical Diffculty Error:" + e.Message);
            }
        }

        public IActionResult CreateStudent()
        {
            StudentModel student = new StudentModel();
            return View(student);
        }

        [HttpPost]
        public IActionResult CreateStudent(StudentModel student)
        {
            try
            {
                string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=Pravakardb;Integrated Security=True;Encrypt=False;";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string command = "INSERT INTO STUDENT" + "(\"Name\", \"Field\", \"Semester\", \"Marks\") VALUES" + " ('" + student.Name + "','" + student.Field + "','" + student.Semester + "','" + student.Marks + "')";
                SqlCommand sqlCommand = new SqlCommand(command, conn);
                sqlCommand.ExecuteNonQuery();
                return RedirectToAction("DisplayStudent");
            }
            catch (Exception e)
            {
                return Content("Technical Diffculty Error:" + e.Message);
            }
        }

        public IActionResult EditStudent(int id)
        {
            try
            {
                StudentModel studentModel = new StudentModel();
                string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=Pravakardb;Integrated Security=True;Encrypt=False;";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string command = "Select * from Student Where Id = " + id;
                SqlCommand sqlCommand = new SqlCommand(command, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow student in dataTable.Rows)
                {
                    studentModel.Id = Convert.ToInt32(student["Id"]);
                    studentModel.Name = student["Name"].ToString();
                    studentModel.Field = student["Field"].ToString();
                    studentModel.Semester = Convert.ToInt32(student["Semester"]);
                    studentModel.Marks = Convert.ToDecimal(student["Marks"]);

                }
                return View(studentModel);
            }
            catch (Exception e)
            {
                return Content("Technical Diffculty Error:" + e.Message);
            }
        }

        [HttpPost]
        public IActionResult EditStudent(StudentModel student)
        {
            try
            {
                string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=Pravakardb;Integrated Security=True;Encrypt=False;";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string command = "Update Student set" + "\"Name\"='" + student.Name + "'" + "," + "\"Field\"='" + student.Field + "'" + "," + "\"Semester\"='" + student.Semester + "'" + "," + "\"Marks\"='" + student.Marks + "'" + " where Id= " + student.Id;
                SqlCommand sqlCommand = new SqlCommand(command, conn);
                sqlCommand.ExecuteNonQuery();
                return RedirectToAction("DisplayStudent");
            }
            catch (Exception e)
            {
                return Content("Technical Diffculty Error:" + e.Message);
            }
        }

        public IActionResult DeleteStudent(int id)
        {
            try
            {
                string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=Pravakardb;Integrated Security=True;Encrypt=False;";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string command = "Delete From Student Where Id = " + id;
                SqlCommand sqlCommand = new SqlCommand(command, conn);
                sqlCommand.ExecuteNonQuery();
                return RedirectToAction("DisplayStudent");
            }
            catch (Exception e)
            {
                return Content("Technical Diffculty Error:" + e.Message);
            }
        }
    }
}