using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment4.Models
{
    public class Trainee
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        public string? Image { get; set; }
        public string? Address { get; set; }
        
        [Range(0, 100)]
        public int Grade { get; set; }

        //[ForeignKey("department")]
        public int DeptId { get; set; }
        public Department? Department { get; set; }
    
        
        public ICollection<CourseResult>? CourseResults { get; set; }
        public CourseResult? CourseResult { get; set; }
    
    


    
    }
}
