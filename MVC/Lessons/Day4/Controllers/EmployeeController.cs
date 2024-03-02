using Day4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day4.Controllers
{
    public class EmployeeController : Controller
    {
        ITIEntities context = new ITIEntities();
        public IActionResult Index()
        {

            return View(context.Employees.ToList());
        }


        // Action for anchor Tag


        public IActionResult Edit(int id) // get data from database 
        {

            var empModel = context.Employees.FirstOrDefault(x => x.Id == id);


            // Why ViewData ? because I need to select the name of the Department not ...
            // the Department Id which is not suitable for user experience
            ViewData["DeptList"] = context.Departments.ToList();

            return View(empModel);
        }


        // Another Action for Submit ===> Save for db
        [HttpPost]
        public IActionResult SaveEdit(int id , Employee employee)
        {
            if (employee.Name != null)
            {
                var oldEmp = context.Employees.Find(id);
                if (oldEmp != null)
                {
                    oldEmp.Name = employee.Name;
                    oldEmp.Address = employee.Address;
                    oldEmp.Age = employee.Age;
                    oldEmp.Salary = employee.Salary;
                    oldEmp.DeptId = employee.DeptId;


                    ViewData["DeptList"] = context.Departments.ToList();

                    context.SaveChanges();

                    return RedirectToAction("Index");
                }
            }
            
            // Why I need the same ViewData like above?
            // because it will throw Null Exception if I don't he can't see it


            return View("Edit" , employee);
        }

        public IActionResult Delete(int id)
        {

            var employee = context.Employees.FirstOrDefault(e => e.Id == id);

            context.Employees.Remove(employee);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
