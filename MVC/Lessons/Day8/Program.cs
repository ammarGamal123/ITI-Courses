using Day8.IRepository;
using Day8.Repository;
using Day8.Models;
using Microsoft.EntityFrameworkCore;
namespace Day8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

             
            // Add services to the container.
            // Built in but need to register.
            builder.Services.AddControllersWithViews();


            

            // Custom Services ===> Register (IoC)
            builder.Services.AddScoped<IStudentRepository, StudentRepository>();
            builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();

            builder.Services.AddDbContext<ITIEntities>(
                optionBuilder =>
                {
                    optionBuilder.UseSqlServer("Data Source =DESKTOP-QU1F590;Initial Catalog=ITI_DB2;Integrated Security=True;TrustServerCertificate=True");
                }
                );

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
                );

            app.Run();
        }
    }
}
