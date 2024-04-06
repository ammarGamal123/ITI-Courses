using Demo.DTOs;
using Demo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using static System.Net.WebRequestMethods;

namespace Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // Resource User
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IConfiguration configuration;

        public AccountController(UserManager<ApplicationUser> userManager , 
            IConfiguration configuration)
        {
            this.userManager = userManager;
            this.configuration = configuration;
        }

        // Create Account new user (Register)
        [HttpPost("Register")] // api/account/register
        public async Task<IActionResult> Registration(RegisterUserDto userDto)
        {
            if (ModelState.IsValid)
            {
                // Save 
                ApplicationUser applicationUser = new ApplicationUser();
                
                applicationUser.UserName = userDto.UserName;
                applicationUser.Email = userDto.Email;

                // IT'S A MUST TO SEND PASSWORD DTO TO userManager TO HASH THIS PASSWORD     
                IdentityResult result =  await userManager.CreateAsync(applicationUser, userDto.Password);
                
                if (result.Succeeded)
                {
                    return Ok("Account Registered Successfully");
                }
                else
                {
                    string errorMessage = string.Empty;
                    foreach (var item in result.Errors)
                    {
                        errorMessage += item.Description + '\n';
                    }

                    return BadRequest(errorMessage);
                } 
                    
            }

            return BadRequest(ModelState);
        }



        // Check Account Validation (Login)
        [HttpPost("login")] // api/account/login
        public async Task<IActionResult> Login(LoginUserDto userDto)
        {
            if (ModelState.IsValid)
            {
               ApplicationUser user = await userManager.FindByNameAsync(userDto.UserName);

                if (user != null) // user name found
                {
                    // Need to check that the user name belong to this password

                    bool found = await userManager.CheckPasswordAsync(user, userDto.Password);
                        if (found) 
                        {
                        // Sure it's correct 
                        // So Create Token

                        // Claims Token 
                        var claims = new List<Claim>();
                        claims.Add(new Claim(ClaimTypes.Name, user.UserName));
                        claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id));
                        claims.Add(new Claim(JwtRegisteredClaimNames.Jti,
                            Guid.NewGuid().ToString()));

                        // Get Role 
                        var roles = await userManager.GetRolesAsync(user);
                        
                        foreach(var itemRole in roles)
                        {
                            claims.Add(new Claim(ClaimTypes.Role, itemRole));
                        }

                        // Needed for create securityKey parameter in SingingCredentials
                        SecurityKey securityKey = new SymmetricSecurityKey(
                            Encoding.UTF8.GetBytes(configuration["JWT:Secret"]));

                        // Signin Credential

                        SigningCredentials signingCredentials = new 
                            SigningCredentials(
                            securityKey
                            ,SecurityAlgorithms.HmacSha256
                            );


                        // Designed for represent to JWT 
                        JwtSecurityToken myToken = new JwtSecurityToken(
                            issuer: configuration["JWT:ValidIssuer"], // url web api (provider)
                            audience: configuration["JWT:ValidAudience"],// url Consumer (Angular)
                            claims: claims,
                            expires: DateTime.Now.AddHours(1),
                            signingCredentials: signingCredentials

                            );


                        return Ok(
                            new
                            {
                                myToken = new JwtSecurityTokenHandler().WriteToken(myToken),
                                expiration = myToken.ValidTo
                            }
                            );
                        } 

                }

                return Unauthorized();
            }

            // Not Valid ( I wanna to throw unauthorized)
            //return BadRequest(ModelState);

            // If ModelState is not valid
            return Unauthorized();
        }
    }
}
