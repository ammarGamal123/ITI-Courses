namespace Day2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            // Inline Middleware ====> anonymous function

            // context = http context , next = reference to my next middleware 
            
            /*Configure(app);*/
            #region Built Middleware Components

             if (!app.Environment.IsDevelopment())
             {
                 app.UseExceptionHandler("/Home/Error");
             }
             app.UseStaticFiles();

             app.UseRouting();

             app.UseAuthorization();

             app.MapControllerRoute(
                 name: "default",
                 pattern: "{controller=Home}/{action=Index}/{id?}");
              app.Run();
 
            app.Run();
            #endregion
        }

        public static void Configure(IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                // can add response or not 
                await context.Response.WriteAsync("1) MiddlWare 1\n");
                
                // can call next middler or not("short circle")
                await next.Invoke();

                await context.Response.WriteAsync("5) MiddleWare 1_2\n");
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("2) MiddleWare 2\n");
                
                // if I commented await next.Invoke() it will be called "short circle"
                await next.Invoke();
                await context.Response.WriteAsync("4) MiddleWare 2_2\n");
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("3) Termainate\n");
            });
        }
    }
}
