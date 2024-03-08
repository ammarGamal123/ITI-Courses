using Microsoft.EntityFrameworkCore;

namespace Assignment3.Models
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
                "Initial Catalog=ITI_AssignmentsDay3;" +
                "Integrated Security=True;" +
                "TrustServerCertificate=True");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Course>()
                .HasMany(c => c.CourseResults)
                .WithOne(cr => cr.Course)
                .HasForeignKey(cr => cr.CourseResultCrsId);


            modelBuilder.Entity<Course>()
                .HasMany(c => c.Instructors)
                .WithOne(i => i.Course)
                .HasForeignKey(i => i.InstructorCrsId);


            modelBuilder.Entity<Course>()
                .HasOne(c => c.Department)
                .WithMany(d => d.Courses)
                .HasForeignKey(c => c.DeptId);


            modelBuilder.Entity<Trainee>()
                .HasMany(t => t.CourseResults)
                .WithOne(cr => cr.Trainee)
                .HasForeignKey(cr => cr.CourseResultCrsId);


            modelBuilder.Entity<Trainee>()
                .HasOne(t => t.Department)
                .WithMany(d => d.Trainees)
                .HasForeignKey(t => t.DeptId);


            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Department)
                .WithMany(d => d.Instructors)
                .HasForeignKey(i => i.DeptId);


            modelBuilder.Entity<Instructor>()
               .Property(i => i.Salary)
               .HasColumnType("decimal(18, 2)");
           

            base.OnModelCreating(modelBuilder);
        }

    }
}
