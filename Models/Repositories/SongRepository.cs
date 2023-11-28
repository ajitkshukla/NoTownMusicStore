using NoTownMusicalStore.Models.Entities;


namespace NoTownMusicalStore.Models.Repositories
{
    public class SongRepository
    {
        protected readonly NoTownDbContext _context;
        public SongRepository(NoTownDbContext context) 
        {
            _context = context;
        }

        public List<Song> GetAllSongs() 
        {
            return _context.Songs.ToList();
        }
        public Song GetSongByTitle(string title)
        {
            return _context.Songs.FirstOrDefault(s => s.Title == title);
        }
        public void AddSong(Song song)
        {
            _context.Songs.Add(song);
            _context.SaveChanges();
        }
        public void UpdateSong(Song song)
        {
            _context.Songs.Update(song);
        }
        public void DeleteSong(Song song)
        {
            _context.Songs.Remove(song);
        }

        
    }
}
