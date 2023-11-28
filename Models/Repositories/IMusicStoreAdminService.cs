using NoTownMusicalStore.Models.Entities;

namespace NoTownMusicalStore.Models.Repositories
{
    public interface IMusicStoreAdminService
    {
        public void AddMusician(Musician musician);
        public void AddAlbum(Album album);
        public void AddSong(Song song);
        public void RemoveSong(Song song);
        public void UpdateSong(Song song);
    }
}
