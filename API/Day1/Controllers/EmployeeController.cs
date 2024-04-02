using Day1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Day1.DTOs;
namespace Day1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ITIEntity context;

        // CRUD Operation

        // To Inject context
        public EmployeeController(ITIEntity _context)
        {
            context = _context;
        }


        [HttpGet]
        public IActionResult Read()
        {
            return Ok(context.Employees.Include(e => e.Department).ToList());
        }

        [HttpGet("{id:int}" , Name = "OneEmployeeRoute")]
        public IActionResult Get1([FromRoute]int id)
        {
            var employee = context.Employees.Include(e => e.Department)
                                            .FirstOrDefault(e => e.Id == id);

            EmployeeDataWithDepartmentNameDTO empDto = new EmployeeDataWithDepartmentNameDTO();
            empDto.Id = employee.Id;
            empDto.Name = employee.Name;
            empDto.Address = employee.Address;
            empDto.Phone = employee.Phone;
            // You have to make sure that this employee has a department 
            // if not it will throw NullException
            empDto.DepartmentName = employee.Department.Name;


            return Ok(empDto);
        }

        [HttpGet("{id:int}")]
        public IActionResult ReadById (int id)
        {
            return Ok(context.Employees.FirstOrDefault(e => e.Id == id));
        }

        [HttpGet("{Name:alpha}")]
        public IActionResult ReadByName (string name)
        {
            return Ok(context.Employees.FirstOrDefault(e => e.Name == name));
        }


        [HttpPost]
        public IActionResult Create([FromBody] Employee employee)
        {
            if (ModelState.IsValid)
            {
                context.Employees.Add(employee);
                context.SaveChanges();

                return Ok(employee);
            }

            return BadRequest(ModelState);
        }

        // Very Important to determine the route (which parameter you expect to get)
        [HttpPut("{id:int}")]
        public IActionResult Update ([FromRoute] int id , [FromBody] Employee employee)
        {
            if (ModelState.IsValid)
            {
                Employee? oldEmp = context.Employees.FirstOrDefault(e => e.Id == id);
                oldEmp.Name = employee.Name;
                oldEmp.Salary = employee.Salary;
                oldEmp.Address = employee.Address;
                oldEmp.Phone = employee.Phone;

                context.SaveChanges();

                //return Created(204, "Employee Updated Successfully");

                // Status Code in Edit && Delete
                return StatusCode(204 , oldEmp);
            }


            return BadRequest(ModelState);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Employee employee = context.Employees.FirstOrDefault(e => e.Id == id);

            if (employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();


                // Status Code in Edit && Delete
                return StatusCode(204, "Employee Removed Successfully");
            }

            return BadRequest(ModelState);
        }
    }
}
