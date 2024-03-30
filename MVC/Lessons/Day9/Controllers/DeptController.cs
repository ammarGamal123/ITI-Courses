using Day9.IRepository;
using Day9.Models;
using Day9.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day9.Controllers
{
    public class DeptController : Controller
    {
        private readonly IDepartmentRepository departmentRepository;

        public DeptController(IDepartmentRepository _departmentRepository)
        {
            departmentRepository = _departmentRepository;
        }

        // ITIEntities context = new ITIEntities();
        // Get All Department
        //Dept/index
        public IActionResult Index()
        {
            // get all department

            List<Department> deptsModel = departmentRepository.GetAll();
    
            return View("Index" , deptsModel);// U Must send it to View otherwise it will throw NULL
        }

        public IActionResult GetEmployees(int deptId)
        {
            var empInDept = departmentRepository.GetEmployees(deptId);

            return Json(empInDept);
        }

        public IActionResult GetStudents(int deptId)
        {
            List<Student> studentsModel = departmentRepository.GetStudents(deptId);

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
                departmentRepository.Insert(dept);

                return RedirectToAction("Index" , "Dept");
            }
            else 
                return View("New" , dept);
        }
    }
}
