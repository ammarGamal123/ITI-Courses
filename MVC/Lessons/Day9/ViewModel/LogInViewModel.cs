using Day9.Models;
using System.ComponentModel.DataAnnotations;

namespace Day9.ViewModel
{
    public class LogInViewModel
    {

        [Required]
        public string? UserName { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
