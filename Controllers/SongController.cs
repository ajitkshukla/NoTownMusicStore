using Microsoft.AspNetCore.Mvc;
using NoTownMusicalStore.Models.Entities;
using NoTownMusicalStore.Models.Repositories.Interfaces;
using NoTownMusicalStore.Models.Services;

namespace NoTownMusicalStore.Controllers
{
    public class SongController : Controller
    {
        private readonly ISongService _SongService;
        private readonly IFileService _FileService;
        private readonly IAlbumService _AlbumService;
        private readonly IMusicianService _MusicianService;
        public SongController(ISongService SongService, IFileService fileService, IAlbumService albumService, IMusicianService musicianService)
        {
            _SongService = SongService;
            _FileService = fileService;
            _AlbumService = albumService;
            _MusicianService = musicianService;
        }
        public IActionResult Add()
        {
            var model = new Song();            
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(Song model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if(model.ImageFile != null)
            {
                var fileResult = this._FileService.SaveImage(model.ImageFile);
                if(fileResult.Item1 == 0)
                {
                    TempData["msg"] = "File could not be saved.";
                    return View(model);
                }
                var imageName = fileResult.Item2;
                model.SongImage = imageName;
            }
            var result = _SongService.Add(model);
            if (result)
            {
                TempData["msg"] = "Song Added Successfully";
                return RedirectToAction(nameof(Add));
            }
            TempData["msg"] = "Error on the server side";
            return View(result);
        }

        public IActionResult Edit(int id)
        {
            var data = _SongService.GetById(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Update(Song model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if (model.ImageFile != null)
            {
                var fileResult = this._FileService.SaveImage(model.ImageFile);
                if(fileResult.Item1 == 0)
                {
                    TempData["msg"] = "File could not be saved";
                    return View(model);
                }
                var imageName = fileResult.Item2;
                model.SongImage = imageName;
            }
            var result = _SongService.Update(model);
            if (result)
            {
                TempData["msg"] = "Successfully Updated";
                return RedirectToAction(nameof(GetAll));
            }
            TempData["msg"] = "Error on the server.";
            return View(model);
        }

        public IActionResult GetAll()
        {
            var data = this._SongService.GetAll();
            return View(data);
        }
        public IActionResult Delete(int id)
        {
            var result = _SongService.Delete(id);
            return RedirectToAction(nameof(GetAll));
        }
    }
}
