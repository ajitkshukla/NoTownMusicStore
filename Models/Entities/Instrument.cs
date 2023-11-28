using System.ComponentModel.DataAnnotations;

namespace NoTownMusicalStore.Models.Entities
{
    public class Instrument
    {
        [Key]
        public string? InstrumentID { get; set; }

        [Required(ErrorMessage = "Instrument name is required")]
        [StringLength(50, ErrorMessage = "Instrument name cannot be longer than 50 characters")]
        [Display(Name = "Instrument Name")]
        public string? dName { get; set; }

        [Required(ErrorMessage = "Key of the instrument is required")]
        [Display(Name = "Key")]
        public string? Key { get; set; }
    }
}
