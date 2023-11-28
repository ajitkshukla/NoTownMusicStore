using Microsoft.AspNetCore.Mvc;
using NoTownMusicalStore.Models.Entities;
using NoTownMusicalStore.Models.Repositories.Interfaces;
using NoTownMusicalStore.Models.Services;

namespace NoTownMusicalStore.Controllers
{
    public class AlbumController : Controller
    {
        private readonly IAlbumService _AlbumService;
        public AlbumController(IAlbumService AlbumService)
        {
            _AlbumService = AlbumService;
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Album model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = _AlbumService.Add(model);
            if (result)
            {
                TempData["msg"] = "Album Added Successfully";
                return RedirectToAction(nameof(Add));
            }
            TempData["msg"] = "Error on the server side";
            return View(result);
        }

        public IActionResult Edit(int id)
        {
            var data = _AlbumService.GetById(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Update(Album model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = _AlbumService.Update(model);
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
            var data = this._AlbumService.GetAll().ToList();
            return View(data);
        }
        public IActionResult Delete(int id)
        {
            var result = _AlbumService.Delete(id);
            return RedirectToAction(nameof(GetAll));
        }
    }
}
