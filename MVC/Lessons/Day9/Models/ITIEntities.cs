using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace Day9.Models
{
    // Requirements for connection to Database: 
    // 1) Database Name 
    // 2) Server Name 
    // 3) Authantication (Windows auth , Admin auth)

    public class ITIEntities : IdentityDbContext<ApplicationUser>
    {
        public ITIEntities()
        {
            
        }
        public ITIEntities(DbContextOptionsBuilder optionsBuilder) : base()
        {

        }

        public ITIEntities(DbContextOptions<ITIEntities> optionsBuilder) : base(optionsBuilder)
        {
            
        }

        /*public ITIEntities(DbContextOptions options) : base(options) { }*/

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*optionsBuilder.UseSqlServer(
                "Data Source =DESKTOP-QU1F590;Initial Catalog=ITI_DB3;Integrated Security=True;TrustServerCertificate=true");
            // dbms , Server Name , db , auth*/

            base.OnConfiguring(optionsBuilder);
        }

        
    }
}
