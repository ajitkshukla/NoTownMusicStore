using NoTownMusicalStore.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace NoTownMusicalStore.Models.ViewModels
{
    public class AddSongViewModel
    {
        [Required(ErrorMessage = "Song title is required.")]
        [Display(Name = "Title")]
        public string? Title { get; set; }
        [Required(ErrorMessage = "Author of the song is required.")]
        [Display(Name = "Author")]
        public string? Author { get; set; }
        [Required(ErrorMessage = "Album of the song is required.")]
        public string? Album { get; set; }
        [Display(Name = "Musicians")]
        public string? Musician { get; set; }
        
    }
}
