using NoTownMusicalStore.Models.Entities;
using NoTownMusicalStore.Models.Repositories.Interfaces;

namespace NoTownMusicalStore.Models.Services
{
    public class AlbumService : IAlbumService
    {
        private readonly NoTownDbContext _context;
        public AlbumService(NoTownDbContext context)
        {
            _context = context;
        }
        public bool Add(Album Album)
        {
            try
            {
                _context.Albums.Add(Album);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var data = this.GetById(id);
                if (data == null)
                    return false;
                _context.Albums.Remove(data);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IQueryable<Album> GetAll()
        {
            return _context.Albums.AsQueryable();
        }

        public Album GetById(int id)
        {
            return _context.Albums.Find(id);
        }

        public bool Update(Album Album)
        {
            try
            {
                _context.Albums.Update(Album);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
