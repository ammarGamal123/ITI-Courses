using System.ComponentModel.DataAnnotations.Schema;

namespace Day7.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }
        public string? Address { get; set; }

        [ForeignKey("Department")]
        public int DeptId { get; set; }
        public Department? Department { get; set; }


    }
}
