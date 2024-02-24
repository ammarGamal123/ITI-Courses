using Day3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day3.Controllers
{
    public class DeptController : Controller
    {
        ITIEntities context = new ITIEntities();
        // Get All Department
        //Dept/index
        public IActionResult Index()
        {
            // get all department
           
            List <Department> deptsModel = context.Departments.ToList();
            
            
            
            return View("Index" , deptsModel);// U Must send it to View otherwise it will throw NULL
        }

        public IActionResult GetStudents(int deptId)
        {
            List<Student> studentsModel = context.Students.Where(s => s.DeptId == deptId).ToList();

            return View("DisplayAllStudents", studentsModel); 
            // Connection between view with model
        }
    }
}
