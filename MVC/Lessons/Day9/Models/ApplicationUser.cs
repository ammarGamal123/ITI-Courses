using Microsoft.AspNetCore.Identity;

namespace Day9.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? Address { get; set; }

    }
}
