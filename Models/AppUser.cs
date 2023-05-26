using Microsoft.AspNetCore.Identity;

namespace S_TCHAD.Models
{
    public class AppUser:IdentityUser
    {
        public string? FullName { get; set; }
    }
}
