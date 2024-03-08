using Day6.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day5.Controllers
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


        // Anchor Tag open empty form 
        [HttpGet] // ====> anchor Tage , Form Method = get
        public IActionResult New()
        {
            return View(new Department()); // Empty Form to receive data from the client
                                           // but Empty isn't correct because it will throw
                                           // exception so we should return new Department()
        }


        // submit button ===> store data inside database 
        // request type = get &type = post
        // dept/savenew?name=ddd&managername=aaa ===> serve (get,post)

        [HttpPost] // ====> it will be read only from ===> Form Method = post 
        public IActionResult SaveNew([Bind(include:"Name,ManagerName")]Department dept)
        {
            if (dept.Name != null && dept.ManagerName != null)
            {
                context.Departments.Add(dept);
                context.SaveChanges();

                return RedirectToAction("Index" , "Dept");
            }
            else 
                return View("New" , dept);
        }
    }
}
