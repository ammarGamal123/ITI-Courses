using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment4.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        
        [Required]
        public string? Name { get; set; }
        public string? Image { get; set; }
        public string? Address { get; set; }

        public decimal Salary { get; set; }


        //[ForeignKey("Department")]
        [Display(Name="Department of Instructor")]
        public int DeptId { get; set; }
        public Department? Department { get; set; }


        //[ForeignKey("course")]
        [Display(Name = "Course of the Instructor")]
        public int InstructorCrsId { get; set; }
        public Course? Course { get; set; }


        

    }
}
