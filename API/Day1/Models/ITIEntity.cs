using Demo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Day1.Models
{
    public class ITIEntity : IdentityDbContext<ApplicationUser>
    {
        // For Wizard 
        public ITIEntity()
        {
                
        }


        // For Injection
        public ITIEntity(DbContextOptions<ITIEntity> dbContextOptions) : base(dbContextOptions)
        {
            
        }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }
    }
}
