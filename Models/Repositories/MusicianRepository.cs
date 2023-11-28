using NoTownMusicalStore.Models.Entities;

namespace NoTownMusicalStore.Models.Repositories
{
    public class MusicianRepository
    {
        private readonly NoTownDbContext _context;

        public MusicianRepository(NoTownDbContext context)
        {
            _context = context;
        }

        public List<Musician> GetAllMusicians()
        {
            return _context.Musicians.ToList();
        }

        public Musician GetMusicianBySSN(string ssn) => _context.Musicians.FirstOrDefault(m => m.SSN == ssn);
        /*public List<Musician> GetMusiciansByName(string name)
        {
            return _context.Musicians.(x  => x.Name == name).ToList();
        }*/

        public void AddMusician(Musician musician)
        {
            _context.Musicians.Add(musician);
            _context.SaveChanges();
        }
        public void UpdateMusician(Musician musician)
        {
            _context.Musicians.Update(musician);
            _context.SaveChanges();
        }
        public void DeleteMusician(string ssn)
        {
            var musician = _context.Musicians.FirstOrDefault(m => m.SSN == ssn);
            if(musician != null)
            {
                _context.Musicians.Remove(musician);
                _context.SaveChanges();
            }
            
        }

    }
}
