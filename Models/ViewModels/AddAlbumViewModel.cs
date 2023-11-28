using NoTownMusicalStore.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace NoTownMusicalStore.Models.ViewModels
{
    public class AddAlbumViewModel
    {
        [Key]
        public int AlbumId { get; set; }
        [Required(ErrorMessage = "Title is required.")]
        public string? Title;

        [Required(ErrorMessage = "Copyright Date is required.")]
        [Display(Name = "Copyright Date")]
        public DateTime CopyrightDate { get; set; }

        [Display(Name = "Speed")]
        public int Speed;

        
        public List<Musician>? Musicians { get; set; }

        public List<Song>? Songs { get; set; }
    }
}
