using NoTownMusicalStore.Models.Entities;

namespace NoTownMusicalStore.Models.DTO
{
    public class SongListViewModel
    {
        public IQueryable<Song> SongList { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public string? Term { get; set; }
    }
}
