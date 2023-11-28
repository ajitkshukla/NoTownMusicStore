using NoTownMusicalStore.Models.Entities;

namespace NoTownMusicalStore.Models.Repositories.Interfaces
{
    public interface IAlbumService
    {
        bool Add(Album album);
        bool Update(Album album);
        Album GetById(int id);
        bool Delete(int id);
        IQueryable<Album> GetAll();
    }
}
