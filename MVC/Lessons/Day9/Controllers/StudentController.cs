using Day9.IRepository;
using Day9.Models;
using Day9.Repository;
using Day9.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Day9.Controllers
{
    // It's a filter to limit who can see the controller 
    [Authorize]
    public class StudentController : Controller
    {
        /*ITIEntities context = new ITIEntities();*/
        //DIP
        IStudentRepository studentRepository;
        IDepartmentRepository departmentRepository;

        // DI
        public StudentController(IStudentRepository _stdRepo , IDepartmentRepository _deptRepo)
        {

            studentRepository = _stdRepo; //new StudentRepository();
            departmentRepository = _deptRepo; //new DepartmentRepository();
        }

        [Route("ITI/{name:alpha}/{age:max(70):min(16)}")]
        public IActionResult TestRoute(string name , int age)
        {
            return Content($"Ok Name = {name} , Age = {age}");
        }

        [AllowAnonymous]
        public IActionResult TestService()
        {
            ViewBag.serviceId = studentRepository.id;
            return View();
        }


        public IActionResult Index()
        {
            string name = User.Identity.Name;

            // ClaimTypes.NameIdentifier

            var id = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);

            return View(studentRepository.GetAll());
        }
        
        // it recieves a parameter casesensetive if it was Age the parameter should be ...
        //                                                 Age
        // Remote Attribute using Ajax Call 
        public IActionResult CheckName (string Name)
        {
            if (Name.Contains("ITI"))
                return Json(true);
            else
                return Json(false);
         }


        [HttpGet] 
        public IActionResult New ()
        {
            ViewData["DeptList"] = departmentRepository.GetAll();
            return View(new Student());
        }


        [ValidateAntiForgeryToken]
        [HttpPost]        // valid overload
        public IActionResult New([Bind(include: "Name,Age,Image,Address,DeptId")] Student student)
        {
            if (ModelState.IsValid)
            {
                // Custom Validation DeptId != 0
                if (student.DeptId != 0)
                {
                    studentRepository.Insert(student);
                    
                    return RedirectToAction("Index");
                }
                else
                {
                    // error message send view 
                    ModelState.AddModelError("DeptId", "Select Department"); // Div
                }
            }

            ViewData["DeptList"] = departmentRepository.GetAll();
            
            return View("New" , student);
        }

        [HttpGet]
        public IActionResult Action1()
        {
            return Json("Get Action1");
        }

        [HttpPost]
        public IActionResult Action1(int id , string name)
        {
            return Json("Post Action1");
        }


        public IActionResult Details()
        {
            Student student = studentRepository.GetById(1); // Model
            List<string> branches = new List<string>
            {
                "Assiut" , "Cairo" , "Beni Suef" , "Mansoura" , "Menia" , "Aswan" ,
                "Alex" , "Menofia" , "Fayoum" , "Sinai" , "Ghardah"
            };

            ViewData["Branches"] = branches; // list of strings
            ViewData["Message"] = "Hello From ActionResult";

            ViewBag.DeptName = "BackEnd (With .NET)";

            ViewBag.DeptGrades = new List <int>{ 20 , 20 , 40 , 35 , 70};

            

            return View("Details", student);
        }

        public IActionResult DetailsWithViewModel()
        {
            StudentWithBranchListViewModel viewModel = new StudentWithBranchListViewModel();

            viewModel.Branches = new List<string> {
                "Cairo", // Cairo Governorate
                "Alexandria", // Alexandria Governorate
                "Giza", // Giza Governorate
                "Shubra El Kheima", // Qalyubia Governorate
                "Port Said", // Port Said Governorate
                "Suez", // Suez Governorate
                "Luxor", // Luxor Governorate
                "Mansoura", // Dakahlia Governorate
                "El-Mahalla El-Kubra", // Gharbia Governorate
                "Tanta", // Gharbia Governorate
                "Asyut", // Asyut Governorate
                "Ismailia", // Ismailia Governorate
                "Fayyum", // Fayoum Governorate
                "Zagazig", // Sharqia Governorate
                "Aswan",
                "Bani Suef"
            };

            /*Student student = context?.Students.FirstOrDefault();
            viewModel.StudentName = student?.Name;
            viewModel.StudentImage = student?.Image;
            viewModel.Message = "Hello Here Is Ammar The GOAT";
            viewModel.Temprature = -2;*/

            return View("DetailsWithViewModel", viewModel);
        }

        
    }
}
