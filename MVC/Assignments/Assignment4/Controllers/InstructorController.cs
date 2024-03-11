using Assignment4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment4.Controllers
{
    public class InstructorController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        // instructor/index
        public IActionResult Index()
        {

            var instList = context.Instructors.Include(d => d.Department)
                                              .Include(c => c.Course)
                                              .AsSplitQuery()
                                              .ToList();


            return View(instList);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {

            var instDetails = context.Instructors.Find(id);
            if (instDetails == null)
            {
                return RedirectToAction("Index");
            }
            return View(instDetails);
        }


        [HttpGet]
        public IActionResult NewInstructor()
        {
            ViewData["DeptList"] = context.Departments.ToList();
            ViewData["CourseList"] = context.Courses.ToList();
            return View(new Instructor());
        }

        [HttpPost]
        public IActionResult SaveNew(Instructor newInstructor)
        {
            ViewData["DeptList"] = context.Departments.ToList();
            ViewData["CourseList"] = context.Courses.ToList();


            if (newInstructor.Name != null)
            {
                context.Instructors.Add(newInstructor);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            
            return View("NewInstructor", newInstructor);
 
        }

        [HttpGet]
        public IActionResult Edit (int id) {
            
            ViewData["DeptList"] = context.Departments.ToList();
            ViewData["CourseList"] = context.Courses.ToList();

            return View(context.Instructors.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(Instructor editedInst) 
        {

            if (editedInst.Name != null)
            {
                context.Instructors.Update(editedInst);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            /*ViewData["DeptList"] = context.Departments.ToList();
            ViewData["CourseList"] = context.Courses.ToList();*/
            
            return View("Edit" ,editedInst);
        }
    }
}
