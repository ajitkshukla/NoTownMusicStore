using Microsoft.AspNetCore.Mvc;
using NoTownMusicalStore.Models.Entities;
using NoTownMusicalStore.Models.Repositories;
using NoTownMusicalStore.Models.Services;

namespace NoTownMusicalStore.Controllers
{
    public class MusicStoreController : Controller
    {
        private readonly IMusicStoreService _musicStoreService;
        public MusicStoreController(IMusicStoreService musicStoreService)
        {
            _musicStoreService = musicStoreService;
        }
        public IActionResult Index()
        {
            List<Song> songs = _musicStoreService.GetAllSongs().Take(20).ToList();
            return View(songs);
        }

        public IActionResult SearchMusician(string name)
        {
            List<Musician> musicians = _musicStoreService.SearchMusicianByName(name);
            //pass the musicians to the view and return it
            return View(musicians);
        }

        public IActionResult SearchAlbumByTitle(string title)
        {
            List<Album> albums = _musicStoreService.SearchAlbumByTitle(title);
            return View(albums);
        }

        public IActionResult SearchSongByName(string name) 
        {
            List<Song> songs = _musicStoreService.SearchSongByTitle(name);
            return View(songs);
        }
    }
}
