using NoTownMusicalStore.Models.Entities;

namespace NoTownMusicalStore.Models.Repositories
{
    public class AlbumRepository
    {
        protected readonly NoTownDbContext _context;
        public AlbumRepository(NoTownDbContext context)
        {
            _context = context;
        }

        public List<Album> GetAllAlbums()
        {
            return _context.Albums.ToList();
        }

        public Album GetAlbumById(int id)
        {
            return _context.Albums.FirstOrDefault(x => x.Id == id);
        }
        public void AddAlbum(Album album)
        {
            _context.Albums.Add(album);
            _context.SaveChanges();
        }
        public void UpdateAlbum(Album album)
        {
            _context.Albums.Update(album);
            _context.SaveChanges();
        }
        public void DeleteAlbum(int id)
        {
            var album = _context.Albums.FirstOrDefault(x => x.Id==id);
            if(album!=null)
            {
                _context.Albums.Remove(album);
                _context.SaveChanges();
            }
        }
    }
}
