using NoTownMusicalStore.Models.Entities;
using NoTownMusicalStore.Models.DTO;

namespace NoTownMusicalStore.Models.Repositories.Interfaces
{
    public interface ISongService
    {
        bool Add(Song song);
        bool Update(Song song);
        Song GetById(int id);
        bool Delete(int id);
        SongListViewModel GetAll(string term = "", bool paging = false, int currentPage = 0);
    }
}
