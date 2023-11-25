using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Project_T_WebApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
