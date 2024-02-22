using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment2.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }
        public string? Address { get; set; }
        public decimal Salary { get; set; }


        [ForeignKey("Department")]
        public int DeptId { get; set; }
        Department? Department { get; set; }


        [ForeignKey("course")]
        public int CourseId { get; set; }
        Course? course { get; set; }
    }
}
