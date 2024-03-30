using Day9.Models;
using Day9.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Day9.Controllers
{
    // [Authorize] // You should have cookie to access this controller
    [Authorize(Roles ="Admin,Employee")] // You have to be LogedIn and You are Admin or Employee
    public class RolesController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;

        public RolesController(RoleManager<IdentityRole> _RoleManager)
        {
            roleManager = _RoleManager;
        }

        // Create Role so I need 2 Actions

        // Link To Display the action
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Submit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Create(RoleViewModel roleVM)
        {
            if (ModelState.IsValid)
            {
                IdentityRole role = new IdentityRole();

                role.Name = roleVM.RoleName;

                IdentityResult result = await roleManager.CreateAsync(role);

                if (result.Succeeded)
                {

                    return View(new RoleViewModel());
                }
                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            

            return View(roleVM);
        }

       
         
    }
}
