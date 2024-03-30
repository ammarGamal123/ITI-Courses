using Day9.IRepository;
using Day9.Repository;
using Day9.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
namespace Day9
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            // Built in but need to register.
            builder.Services.AddControllersWithViews();

            
            builder.Services.AddDbContext<ITIEntities>(
                optionBuilder =>
                {
                    optionBuilder.UseSqlServer(builder.Configuration.GetConnectionString("Cs1"));
                }
                );
            
            // Register userManager , roleManager ===> UserStore , RoleStore
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(
                options => options.Password.RequireDigit = true 
                )
                            .AddEntityFrameworkStores<ITIEntities>();

            // Custom Services ===> Register (IoC)
            builder.Services.AddScoped<IStudentRepository, StudentRepository>();
            builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            
            
            
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            
            app.UseStaticFiles();

            app.UseRouting();


            // How to check the cookie
            app.UseAuthentication(); // Request
            
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
                );

            app.Run();
        }
    }
}
