using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class StudentController : Controller
    {
        


        // student/Index ====> View Students Data
        public IActionResult Index()
        {
            StudentSampleData studentBL = new StudentSampleData();

            List<Student> studentList = new List<Student>();
            studentList = studentBL.getStudentsData();

            return View("Index", studentList);
        }

        public IActionResult Details(int id)
        {

            StudentSampleData studentBL = new StudentSampleData();
            Student studentById = studentBL.getStudentById(id);

            return View("Details", studentById);
        }
    }
}
