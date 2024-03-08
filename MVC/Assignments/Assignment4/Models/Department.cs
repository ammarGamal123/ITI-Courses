using System.ComponentModel.DataAnnotations;

namespace Assignment3.Models
{
    public class Department
    {
        public int Id { get; set; }
        
        [Required]
        public string? Name { get; set; }   
        public string? ManagerName { get; set; }

        
        public ICollection<Course>? Courses { get; set; }
        public Course? Course { get; set; }


        public ICollection<Trainee>? Trainees { get; set; }
        public Trainee? Trainee { get; set; }

        
        public ICollection<Instructor>? Instructors { get; set; }
        public Instructor? Instructor { get; set; }
    }
}
