using NoTownMusicalStore.Models.Repositories;
using NoTownMusicalStore.Models;
using NoTownMusicalStore.Models.Entities;

namespace NoTownMusicalStore.Models.Services
{
    public class MusicStoreService : IMusicStoreService
    {
        private readonly MusicianRepository _musicianRepository;
        private readonly AlbumRepository _albumRepository;
        private readonly SongRepository _songRepository;
        private readonly InstrumentRepository _instrumentRepository;
       

        public MusicStoreService(MusicianRepository musicianRepository, AlbumRepository albumRepository, SongRepository songRepository, InstrumentRepository instrumentRepository) 
        {
            _musicianRepository = musicianRepository;
            _albumRepository = albumRepository;
            _songRepository = songRepository;
            _instrumentRepository = instrumentRepository;
           
        }

        public List<Musician> SearchMusicianByName(string name)
        {
            return _musicianRepository.GetAllMusicians().Where(x => x.Name == name).ToList();
        }

        public List<Album> SearchAlbumByTitle(string title) 
        {
            return _albumRepository.GetAllAlbums().Where(x => x.Title == title).ToList();
        }

       /* public List<Album> SearchAlbumByMusician(string musician)
        {
            return _albumRepository.GetAllAlbums().Where(x => x.Musicians != null && x.Musicians.Any(m => m.Name == musician)).ToList();
        }
        public List<Album> SearchAlbumBySong(string song)
        {
            return _albumRepository.GetAllAlbums().Where(x => x.Songs != null && x.Songs.Any(s => s.Title == song)).ToList();
        }*/

        // Methods related to SongRepository.cs
        public List<Song> GetAllSongs()
        {
            return _songRepository.GetAllSongs();
        }
        public List<Song> SearchSongByTitle(string title)
        {
            return _songRepository.GetAllSongs().Where(song => song.Title == title).ToList();
        }
        /*public List<Song> SearchSongByMusician(string musician)
        {
            return _songRepository.GetAllSongs().Where(song => song.Musicians == musician).ToList();
        }*/
    }

    
}
