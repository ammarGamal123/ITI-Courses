using System.ComponentModel.DataAnnotations.Schema;

namespace Day2.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }
        public string? Address { get; set; }


        [ForeignKey("Department")]
        public int DeptId { get; set; }

        public Department? Department { get; set; }

    }
}
