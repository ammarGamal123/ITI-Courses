using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment2.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }
        public string? Address { get; set; }
        public int Grade { get; set; }

        [ForeignKey("department")]
        public int DeptId { get; set; }
        Department? Department { get; set; }
    
    
    }
}
