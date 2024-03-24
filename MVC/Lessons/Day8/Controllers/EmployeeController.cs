using Day8.IRepository;
using Day8.Models;
using Day8.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Security;

namespace Day8.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployeeRepository employeeRepository = new EmployeeRepository();
        //ITIEntities context = new ITIEntities();
        public IActionResult Index()
        {

            return View(employeeRepository.GetAll());
        }

        public IActionResult Ajax()
        {
            var employee = employeeRepository.GetAll();
            return View(employee);
        }

        // Action for anchor Tag


        public IActionResult Edit(int id) // get data from database 
        {

            var empModel = employeeRepository.GetById(id);

            ViewData["DeptList"] = employeeRepository.GetDepartments();
            // Why ViewData ? because I need to select the name of the Employee not ...
            // the Employee Id which is not suitable for user experience

            return View(empModel);
        }


        // Another Action for Submit ===> Save for db
        [HttpPost]
        public IActionResult SaveEdit(int id , Employee employee)
        {
            if (employee.Name != null)
            {
                var oldEmp = employeeRepository.GetById(id);
                if (oldEmp != null)
                {
                    employeeRepository.Edit(id, employee);
                    
                    ViewData["DeptList"] = employeeRepository.GetDepartments();

                    return RedirectToAction("Index");
                }
            }
            
            // Why I need the same ViewData like above?
            // because it will throw Null Exception if I don't he can't see it


            return View("Edit" , employee);
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {

            return View(employeeRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult ConfirmDelete(int id)
        {
            employeeRepository.Delete(employeeRepository.GetById(id));

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Details(int id)
        {
            var employee =
                employeeRepository.GetById(id);

            return View("Details", employee);
        }


        public IActionResult TestPartialView(int id)
        {
            var employee =
                employeeRepository.GetById(id);

            return PartialView("_EmployeeCard", employee);
        }


    }
}
