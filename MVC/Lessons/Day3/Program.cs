using Day3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

using Microsoft.Extensions.DependencyInjection; 

namespace Day3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
           
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            
            // for adding Session
            builder.Services.AddSession(sessoinOptions =>
            {
                        sessoinOptions.IdleTimeout = TimeSpan.FromMinutes(20);
            });

            var app = builder.Build();

            
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            // Using Session
            app.UseSession();

            app.UseRouting();

            app.UseAuthorization();

            // Configure(app);

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }


    }
}
