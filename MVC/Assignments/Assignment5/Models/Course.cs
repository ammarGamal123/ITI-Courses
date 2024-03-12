using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment5.Models
{
    public class Course
    {
        
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        
        [Range(0, 100)]
        public int Degree { get; set; }
        
        [Range(0, 100)]
        public int MinDegree { get; set; }



        public ICollection<CourseResult>? CourseResults { get; set; }
        public CourseResult? CourseResult { get; set; }


        public ICollection<Instructor>? Instructors { get; set; }
        public Instructor? Instructor { get; set; }



        //[ForeignKey ("Department")]
        [Display(Name = "Department of Coruse")]
        public int? DeptId { get; set; }
        public Department? Department { get; set; }

    }
}
