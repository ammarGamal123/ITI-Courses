using Assignment3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment3.Controllers
{
    public class InstructorController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        // instructor/index
        public IActionResult Index()
        {
            var InsructorList = context.Instructors.ToList();
            if (InsructorList != null )
                return View("Index", InsructorList);
            else 
                return View("Error"); 
        }

        public IActionResult Details(int id)
        {
            var InstructorDetails = context.Instructors.FirstOrDefault(i => i.Id == id);

            return View("Details", InstructorDetails);
        }


    }
}
