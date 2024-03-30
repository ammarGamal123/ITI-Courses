using Day9.Models;
using Day9.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Day9.Controllers
{
    public class AccountController : Controller
    {
        // Inject
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> _UserManager, 
                    SignInManager<ApplicationUser> _SignInManager)
        {
            userManager = _UserManager;
            signInManager = _SignInManager;
        }

        [HttpGet] //<a href>
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterUserViewModel newUserVM)
        {
            if (ModelState.IsValid)
            {
                // Create Account
                ApplicationUser userModel = new ApplicationUser();
                userModel.UserName = newUserVM.UserName;
                userModel.Address = newUserVM.Address;
                userModel.PasswordHash = newUserVM.Password;

                IdentityResult result = await userManager.CreateAsync(userModel,newUserVM.Password);
                if (result.Succeeded)
                {
                    // Create Cookie
                    await signInManager.SignInAsync(userModel,false);

                    return RedirectToAction("Index", "Student");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }

            return View(newUserVM);
        }


        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> LogIn(LogInViewModel UserVM)
        {
            if (ModelState.IsValid)
            {
                // Check User Manager

                ApplicationUser? userModel = await userManager.FindByNameAsync(UserVM?.UserName);
                if (userModel != null)
                {
                    
                        bool matched = await userManager.CheckPasswordAsync(userModel,
                                                                            UserVM.Password);
                    if (matched)
                    {
                        //await signInManager.SignInAsync(userModel, UserVM.RememberMe);
                        List<Claim> Claims = new List<Claim>();
                        Claims.Add(new Claim("Address", userModel.Address));


                        await signInManager.SignInWithClaimsAsync(
                            userModel , UserVM.RememberMe, Claims); 

                        return RedirectToAction("Index", "Student");
                    }
                    else
                        ModelState.AddModelError("", "Password is Invalid");

                    
                }
                else
                {
                    ModelState.AddModelError("", "User Name And Password InValid");
                }

            }

            return View(UserVM);
        }



        // Admin ( Can Add Admin)
      //  [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult AddAdmin()
        {
            return View();
        }


       // [Authorize (Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> AddAdmin(RegisterUserViewModel UserVM)
        {
            if (ModelState.IsValid)
            {

                
                ApplicationUser applicationUser = new ApplicationUser();
                applicationUser.UserName = UserVM.UserName;
                applicationUser.Address = UserVM.Address;
                applicationUser.PasswordHash = UserVM.Password;
                
                var result = await userManager.CreateAsync(applicationUser);
                if (result.Succeeded)
                {
                    // Assign Role ===> Adding Role to a Certain User
                    await userManager.AddToRoleAsync(applicationUser, "Admin");

                    // Create Cookie
                    await signInManager.SignInAsync(applicationUser, false);

                    return RedirectToAction("Index", "Student");
                }
                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }

            }


            return View(UserVM);
        }


        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("LogIn", "Account");
        }

    } 
}
