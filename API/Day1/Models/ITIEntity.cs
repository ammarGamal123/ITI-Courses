using Microsoft.EntityFrameworkCore;

namespace Day1.Models
{
    public class ITIEntity : DbContext
    {
        // For Wizard 
        public ITIEntity()
        {
                
        }


        // For Injection
        public ITIEntity(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }
    }
}
