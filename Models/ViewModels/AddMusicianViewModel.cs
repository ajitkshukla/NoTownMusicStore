using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace NoTownMusicalStore.Models.ViewModels
{
    public class AddMusicianViewModel
    {
        [Key]
        public string? SSN { get; set; }

        [Required(ErrorMessage = "Musician name is required")]
        [StringLength(50, ErrorMessage = "Name should not exceed 50 characters")]
        [Display(Name = "Name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [StringLength(10, ErrorMessage = "Phone number should be 10 digits")]
        [Display(Name = " Phone number")]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        public String? Address { get; set; }
    }
}
