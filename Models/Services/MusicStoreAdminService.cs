using NoTownMusicalStore.Models.Entities;
using NoTownMusicalStore.Models.Repositories;

namespace NoTownMusicalStore.Models.Services
{
    public class MusicStoreAdminService : IMusicStoreAdminService
    {
        private readonly MusicianRepository _musicianRepository;
        private readonly AlbumRepository _albumRepository;
        private readonly SongRepository _songRepository;
        private readonly InstrumentRepository _instrumentRepository;
      

        public MusicStoreAdminService(MusicianRepository musicianRepository, AlbumRepository albumRepository, SongRepository songRepository, InstrumentRepository instrumentRepository)
        {
            _musicianRepository = musicianRepository;
            _albumRepository = albumRepository;
            _songRepository = songRepository;
            _instrumentRepository = instrumentRepository;
           
        }

        public void AddMusician(Musician musician)
        {
            _musicianRepository.AddMusician(musician);
        }
        
        public void AddAlbum(Album album)
        {
            _albumRepository.AddAlbum(album);
        }

        public void AddSong(Song song)
        {
            _songRepository.AddSong(song);
        }

        public void RemoveSong(Song song)
        {
            _songRepository.DeleteSong(song);
        }

        public void UpdateSong(Song song)
        {
            _songRepository.UpdateSong(song);
        }
    }
}
