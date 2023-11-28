using Microsoft.AspNetCore.Mvc;
using NoTownMusicalStore.Models.Repositories.Interfaces;

namespace NoTownMusicalStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISongService _songService;
        public HomeController(ISongService songService)
        {
            _songService = songService;
        }
        public IActionResult Index(string term = "", int currentPage = 1)
        {
            var songs = _songService.GetAll(term,true, currentPage);
            return View(songs);
        }
        public IActionResult SongDetail(int songId)
        {
            var song = _songService.GetById(songId);
            return View(song);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
