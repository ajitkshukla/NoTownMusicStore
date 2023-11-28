using NoTownMusicalStore.Models.Entities;

namespace NoTownMusicalStore.Models.Repositories.Interfaces
{
    public interface IMusicianService
    {
        bool Add(Musician musician);
        bool Update(Musician musician);
        Musician GetById(string id);
        bool Delete(string id);
        IQueryable<Musician> GetAll();
    }
}
