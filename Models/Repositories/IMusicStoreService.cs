using NoTownMusicalStore.Models;
using NoTownMusicalStore.Models.Entities;

namespace NoTownMusicalStore.Models.Repositories
{
    public interface IMusicStoreService
    {
        List<Musician> SearchMusicianByName(string name);
        List<Album> SearchAlbumByTitle(string title);
        /*List<Album> SearchAlbumByMusician(string producer);
        List<Album> SearchAlbumBySong(string song);*/
        // Methods related to SongRepository.cs
        List<Song> GetAllSongs();
        List<Song> SearchSongByTitle(string title);
        //List<Song> SearchSongByMusician(string musician);
        
    }
}
