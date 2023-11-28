using Microsoft.AspNetCore.Identity;

namespace NoTownMusicalStore.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
    }
}
