
using Day1.Models;
using Demo.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Day1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            

            builder.Services.AddCors(corsOption =>
            {
                corsOption.AddPolicy("MyPolicy" , CorsPolicyBuilder =>
                {
                    // To Allow any domain
                    CorsPolicyBuilder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();

                    // to customize a certain http (Angular)
                    //CorsPolicyBuilder.WithOrigins("http://localhost:4200")
                });
            });


           

            builder.Services.AddDbContext<ITIEntity>(options =>
            {
                options.UseSqlServer("Data Source =DESKTOP-QU1F590;Initial Catalog=ITIWebAPI;Integrated Security=True;TrustServerCertificate=true");
            });

            // For Injection to create userManager
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
               .AddEntityFrameworkStores<ITIEntity>()
               .AddDefaultTokenProviders();

            // to [Authorize] Used JWT Token in Check Authentication
            builder.Services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme =
                JwtBearerDefaults.AuthenticationScheme;

                option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

                option.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;



            }).AddJwtBearer(option =>
            {
                option.SaveToken = true;
                option.RequireHttpsMetadata = false; // HTTPS 
                option.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidIssuer = builder.Configuration["JWT:ValidIssuer"],
                    ValidateAudience = true,
                    ValidAudience = builder.Configuration["JWT:ValidAudience"],
                    IssuerSigningKey = new SymmetricSecurityKey(
                            Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]))
            };
            });



            var app = builder.Build();
            
            
            // it's a middle ware to display html pages or images
            //app.UseStaticFiles(); // html , Images

            //app.UseCors("MyPolicy"); // Customize Policy open for 1 , 2 , 3
            // to open policy we need to declare configureService method



            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
                   
            }

            app.UseAuthentication(); // Check JWT Token 
            
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
