using Assignment4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment4.Controllers
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
