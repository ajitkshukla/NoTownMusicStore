using Microsoft.AspNetCore.Mvc;
using NoTownMusicalStore.Models.Entities;
using NoTownMusicalStore.Models.Repositories.Interfaces;
using NoTownMusicalStore.Models.Services;

namespace NoTownMusicalStore.Controllers
{
    public class MusicianController : Controller
    {
        private readonly IMusicianService _musicianService;
        public MusicianController(IMusicianService musicianService)
        {
            _musicianService = musicianService;
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Musician model)
        {
            if (!ModelState.IsValid)
            {
                return  View(model);
            }
            var result = _musicianService.Add(model);
            if(result)
            {
                TempData["msg"] = "Musician Added Successfully";
                return RedirectToAction(nameof(Add));
            }
            TempData["msg"] = "Error on the server side";
            return View(result);
        }

        public IActionResult Edit(string id)
        {
            var data = _musicianService.GetById(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Update(Musician model) 
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = _musicianService.Update(model);
            if (result)
            {
                TempData["msg"] = "Successfully Updated";
                return RedirectToAction(nameof(GetAll));
            }
            TempData["msg"] = "Error on the server.";
            return View(model) ;
        }

        public IActionResult GetAll()
        {
            var data = this._musicianService.GetAll().ToList();
            return View(data);
        }
        public IActionResult Delete(string id) 
        {
            var result = _musicianService.Delete(id);
            return RedirectToAction(nameof(GetAll));
        }
    }
}
