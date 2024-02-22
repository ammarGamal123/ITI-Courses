using Assignment2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    public class InstructorController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        
        // instructor/index
        public IActionResult Index()
        {
            var InsructorList = context.Instructors.ToList();

            return View("Index" , InsructorList);
        }

        public IActionResult Details(int id)
        {
            var InstructorDetails = context.Instructors.FirstOrDefault(i => i.Id == id);

            return View("Details" , InstructorDetails);
        }
    }
}
