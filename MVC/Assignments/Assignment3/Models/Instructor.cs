using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment3.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        
        [Required]
        public string? Name { get; set; }
        public string? Image { get; set; }
        public string? Address { get; set; }

        [Range(0, (double)decimal.MaxValue)] // Adjust range based on salary scale
        public decimal Salary { get; set; }


        //[ForeignKey("Department")]
        public int DeptId { get; set; }
        public Department? Department { get; set; }


        //[ForeignKey("course")]
        public int CourseId { get; set; }
        public Course? Course { get; set; }


        

    }
}
