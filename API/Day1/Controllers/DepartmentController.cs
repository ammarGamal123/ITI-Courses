using Day1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Day1.DTOs;
using Microsoft.EntityFrameworkCore;
using Demo.DTOs;
using Microsoft.AspNetCore.Authorization;
namespace Day1.Controllers
{
    // Need Request Verb GET|POST|PUT|DELETE    
    [Route("api/[controller]")] // Should be called = api/Department ===> Uniform Interface (UI) 
    [ApiController] // to distinguish that it's API Controller NOT MVC Controller
    [Authorize]
    public class DepartmentController : ControllerBase // response according to status Code
    {
        private readonly ITIEntity context;

        // Action

        public DepartmentController(ITIEntity _context)
        {
            context = _context;
        }

        // api/Department
        [HttpGet]
        public IActionResult Read()
        {
            List<Department> departmentList = context.Departments
                .Include(d => d.Employees).ToList();

            List<GetDepartmentEmployeesDetailsDto> deptDtos = new List<GetDepartmentEmployeesDetailsDto>();

            foreach (var department in departmentList)
            {
                var deptDto = new GetDepartmentEmployeesDetailsDto()
                {
                    DeptId = department.Id,
                    DeptName = department.Name,
                    DeptManager = department.Manager,
                    // Get Employees Name 
                    EmployeesName = department.Employees.Select(p => p.Name).ToList(),
                };
                deptDtos.Add(deptDto);
            }


            return Ok(deptDtos); // Response Body as a Json
        }


        [HttpGet("{id:int}", Name = "GetOneDepartmentRoute")]
        //[Route("{id:int}")] // Route makes The difference Between 2 HttpGet
        public IActionResult ReadById(int id)
        {
            Department department = context.Departments.Include(d => d.Employees)
                .FirstOrDefault(d => d.Id == id);


            GetDepartmentEmployeesDetailsDto deptDto = new GetDepartmentEmployeesDetailsDto();
            deptDto.DeptId = department.Id;
            deptDto.DeptName = department.Name;
            deptDto.DeptManager = department.Manager;
            foreach (var item in department.Employees)
            {
                deptDto.EmployeesName.Add(item.Name);
            }

            return Ok(deptDto);
        }


        [HttpGet("{name:alpha}")]
        //[Route("{name:alpha}")]
        public IActionResult ReadByName(string name)
        {
            Department? department = context.Departments.FirstOrDefault(
                d => d.Name == name);

            return Ok(department);
        }

        [HttpPost] // Add Resource Department 
        public IActionResult Create(Department department)
        {
            if (ModelState.IsValid)
            {
                // If I Create the status code will be 201
                // this status code adds location which is the url of the action


                context.Departments.Add(department);
                context.SaveChanges();

                /*return Created("http://localhost:21390/api/department/" + department.Id,
                    department);*/

                // How to get the current domain
                string? url = Url.Link("GetOneDepartmentRoute", new {id = department.Id});
                
                return Created(url, department);
            }

            //return BadRequest("Department Not Valid");
            return BadRequest(ModelState); 
        }

        

        // Very Important to determine the route (expected parameter from route)
        // api/department/7
        [HttpPut("{id:int}")]
        //[FromRoute] ==> means id will be called from the route 
        public IActionResult Update([FromRoute] int id ,[FromBody] Department newDepartment)
        {
            if (ModelState.IsValid)
            {
                Department oldDept = context.Departments.FirstOrDefault(d => d.Id == id);

                oldDept.Name = newDepartment.Name;
                oldDept.Manager = newDepartment.Manager;
                context.SaveChanges();

                // In Update && Delete We return Status Code ==> 204 
                return StatusCode(204, oldDept); 
            }

            return BadRequest(ModelState);
        }
        [HttpDelete("{id:int}")]
        public IActionResult Remove(int id)
        {
            if (ModelState.IsValid)
            {
                Department department = context.Departments.FirstOrDefault(de => de.Id == id);
                if (department != null)
                {
                    try
                    {
                        context.Departments.Remove(department);
                        context.SaveChanges();

                        return StatusCode(204, "Record Removed Successfully");
                    }
                    catch (Exception ex)
                    {
                        return BadRequest(ex.Message);
                    }

                    // In Delete we send Status Code ===> 204
                    
                }
                else 
                    return BadRequest("Id is not correct");   
            }


            return BadRequest(ModelState);
        }


    }
}
