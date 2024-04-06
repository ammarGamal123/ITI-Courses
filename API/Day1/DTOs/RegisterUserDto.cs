using System.ComponentModel.DataAnnotations;

namespace Demo.DTOs
{
    public class RegisterUserDto
    {
        [Required]
        public string UserName { get; set; } = string.Empty;


        [Required]
        public string Password { get; set; } = string.Empty;


        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; } = string.Empty;
        
        
        [Required]
        public string Email { get; set; } = string.Empty;

    }
}
