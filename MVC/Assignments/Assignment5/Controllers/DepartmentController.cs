using Assignment5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment5.Controllers
{
    public class DepartmentController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            return View(context.Departments.ToList());
        }
    }
}
