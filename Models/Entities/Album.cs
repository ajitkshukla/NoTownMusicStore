using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NoTownMusicalStore.Models.Entities
{
    public class Album
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        public DateTime CopyrightDate { get; set; }

        public int Speed { get; set; }
        [NotMapped]
        public string? Musicians { get; set; }
        [NotMapped]
        public string? Songs { get; set; }

        
    }
}
