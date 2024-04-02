using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day1.Models
{
    public class Employee
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Name Is Required")]
        public string Name { get; set; }

        [Required]
        public decimal Salary { get; set; }

        [Required]
        public string Address { get; set; }

        public string Phone { get; set; }

        [ForeignKey("Department")]
        public int DeptId { get; set; }
        public virtual Department Department { get; set; }
    }
}
