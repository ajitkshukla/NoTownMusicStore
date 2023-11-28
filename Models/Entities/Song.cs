using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NoTownMusicalStore.Models.Entities
{
    public class Song
    {
        [Key]
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Author { get; set; }
        public string? SongImage { get; set; }
        
        public string? Album { get; set; }
        
        public string? Musicians { get; set; }
        [NotMapped]
        public IFormFile? ImageFile { get; set; }
      
    }
}
