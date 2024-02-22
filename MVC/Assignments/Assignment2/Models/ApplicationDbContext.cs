using Microsoft.EntityFrameworkCore;

namespace Assignment2.Models
{
    public class ApplicationDbContext:DbContext
    {

        public DbSet<Instructor>? Instructors { get; set; }
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Department>? Departments {get;set; }
        public DbSet<Trainee>? Traines { get; set; }
        public DbSet<CourseResult>? CourseResults { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source =DESKTOP-QU1F590;" +
                "Initial Catalog=ITI_Assignments;" +
                "Integrated Security=True;" +
                "TrustServerCertificate=True");

            base.OnConfiguring(optionsBuilder);
        }

    }
}
