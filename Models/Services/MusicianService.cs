using NoTownMusicalStore.Models.Entities;
using NoTownMusicalStore.Models.Repositories.Interfaces;

namespace NoTownMusicalStore.Models.Services
{
    public class MusicianService : IMusicianService
    {
        private readonly NoTownDbContext _context;
        public MusicianService(NoTownDbContext context)
        {
            _context = context;
        }
        public bool Add(Musician Musician)
        {
            try
            {
                _context.Musicians.Add(Musician);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(string id)
        {
            try
            {
                var data = this.GetById(id);
                if (data == null)
                    return false;
                _context.Musicians.Remove(data);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IQueryable<Musician> GetAll()
        {
            return _context.Musicians.AsQueryable();
        }

        public Musician GetById(string id)
        {
            return _context.Musicians.Find(id);
        }

        public bool Update(Musician Musician)
        {
            try
            {
                _context.Musicians.Update(Musician);
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
