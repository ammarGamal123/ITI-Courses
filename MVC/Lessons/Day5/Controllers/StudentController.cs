using Day5.Models;
using Day5.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Day5.Controllers
{
    public class StudentController : Controller
    {
        ITIEntities context = new ITIEntities();
        
        public IActionResult Index()
        {
            return View(context.Students.ToList());
        }
        
        
        [HttpGet]
        public IActionResult New ()
        {
            ViewData["DeptList"] = context.Departments.ToList();
            return View(new Student());
        }


        
        [HttpPost]        // valid overload
        public IActionResult New([Bind(include: "Name,Age,Image,Address,DeptId")] Student student)
        {
            if (student.Name != null)
            {
                context.Students.Add(student);
                context.SaveChanges();
                
                return RedirectToAction("Index");
            }

            ViewData["DeptList"] = context.Departments.ToList();
            
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
            Student student = context.Students.FirstOrDefault(); // Model
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

            Student student = context?.Students.FirstOrDefault();
            viewModel.StudentName = student?.Name;
            viewModel.StudentImage = student?.Image;
            viewModel.Message = "Hello Here Is Ammar The GOAT";
            viewModel.Temprature = -2;

            return View("DetailsWithViewModel", viewModel);
        }


    }
}
