using System.ComponentModel.DataAnnotations;

namespace Day9.ViewModel
{
    public class RegisterUserViewModel
    {
        [Required]
        public string? UserName { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string? Password { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [Compare("Password")]
        public string? ConfirmPassword { get; set; }

    

        public string? Address { get; set; }

    }
}
