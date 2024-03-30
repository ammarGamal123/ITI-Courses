using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
/*using Newtonsoft.Json.Serialization;*/
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day9.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]

        [MaxLength(30)]
        [MinLength(3)]
        [UniqueName(Msg = "Hiiii From public Property in UniqueaName Class")]
        //[RegularExpression("[A-Za-z]")]
        [Remote(action:"CheckName" , controller:"Student"
            ,ErrorMessage ="Name Must Contain ITI")]
        public string? Name { get; set; }


        [Required]
        [Range(20,30)]
        [Display(Name="Student Age")]
        public int Age { get; set; }


        [Required]
        [RegularExpression(@"\w+\.(jpg|png)",ErrorMessage ="Image Must be jpg or png")]
        public string? Image { get; set; }

        [Required]
        [RegularExpression(@"(Alex|Assiut)")]
        public string? Address { get; set; }


        [ForeignKey("Department")]
        public int DeptId { get; set; }

        public Department? Department { get; set; }

    }
}
