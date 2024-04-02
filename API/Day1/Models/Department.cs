using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Day1.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Manager Name is required")]
        public string Manager { get; set; }


        
        //[JsonIgnore] // Not Preferred but it's a solution to remove cycling
        public virtual List<Employee> Employees { get; set; }

    }
}
