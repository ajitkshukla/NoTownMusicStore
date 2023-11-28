

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NoTownMusicalStore.Models.Entities
{
    public class Musician
    {
        [Key]
        public string? SSN { get; set; }        
        public string? Name { get; set; }        
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
    }
}
