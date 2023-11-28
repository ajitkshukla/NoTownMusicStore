using System.ComponentModel.DataAnnotations;

namespace NoTownMusicalStore.Models.DTO
{
    public class LoginModel
    {
        public string Username { get; set; }

        [Required]        
        public string Password { get; set; }
        
    }
}
