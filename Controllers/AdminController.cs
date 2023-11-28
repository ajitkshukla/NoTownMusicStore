using Microsoft.AspNetCore.Mvc;
using NoTownMusicalStore.Models.Entities;
using NoTownMusicalStore.Models.Repositories;
using NoTownMusicalStore.Models.ViewModels;

namespace NoTownMusicalStore.Controllers
{
    public class AdminController : Controller
    {
        private readonly IMusicStoreAdminService _musicStoreAdminService;
        public AdminController(IMusicStoreAdminService musicStoreAdminService)
        {
            _musicStoreAdminService = musicStoreAdminService;
        }
        public IActionResult Index()
        {

            return RedirectToAction("Index", "MusicStore");
        }

        public IActionResult AddSong()
        {
            var model = new AddSongViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddSong(AddSongViewModel model)
        {
            if (ModelState.IsValid)
            {
                var song = new Song
                {
                    Title = model.Title,
                    Author = model.Author,
                    //Album = model.Album
                };
                _musicStoreAdminService.AddSong(song);

                // Redirect to the Index action method of the MusicStoreController
                return RedirectToAction("Index", "MusicStore");
            }
            return View(model);
        }

        public IActionResult AddMusician()
        {
            var model = new AddMusicianViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddMusician(AddMusicianViewModel model)
        {
            if(ModelState.IsValid)
            {
                var musician = new Musician
                {
                    SSN = model.SSN,
                    Name = model.Name,
                    Address = model.Address,
                    PhoneNumber = model.PhoneNumber,
                };
                _musicStoreAdminService.AddMusician(musician);

                // Redirect to the Index action method of the MusicStoreController
                return RedirectToAction("Index", "MusicStore");
            }
            return View(model);

        }

        [HttpGet]
        public IActionResult AddAlbum()
        {
            var model = new AddAlbumViewModel();
            return View(model);
        }

        public IActionResult AddAlbum(AddAlbumViewModel model)
        {
            if (ModelState.IsValid)
            {
                var album = new Album
                {
                    Id = model.AlbumId,
                    Title = model.Title,
                    Speed = model.Speed,
                    CopyrightDate = model.CopyrightDate,
                    
                };
                _musicStoreAdminService.AddAlbum(album);

                // Redirect to the Index action method of the MusicStoreController
                return RedirectToAction("Index", "MusicStore");
            }
            return View(model);
        }
        
    }
}
