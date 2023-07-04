using Microsoft.AspNetCore.Identity;
using S_TCHAD.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace S_TCHAD.Models
{
    public class AppUser : IdentityUser 
    {
        public string? FullName { get; set; }
    }
}
