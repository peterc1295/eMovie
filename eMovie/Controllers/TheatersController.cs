using eMovie.Models;
using eMovie.Models.Data;
using eMovie.Models.Data.Services;
using eMovie.Models.Data.Static;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eMovie.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class TheatersController : Controller
    {
        private readonly ITheatersService _service;

        public TheatersController(ITheatersService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allTheaters = await _service.GetAllAsync();
            return View(allTheaters);
        }

        //GET: producers/create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Logo,Description")] Theaters theater)
        {
            if (!ModelState.IsValid) return View(theater);

            await _service.AddAsync(theater);
            return RedirectToAction(nameof(Index));
        }

        //GET: producers/details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }


        //GET: producers/edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var theaterDetails = await _service.GetByIdAsync(id);
            if (theaterDetails == null) return View("NotFound");
            return View(theaterDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Theaters theater)
        {
            if (!ModelState.IsValid)
            {
                return View(theater);
            }
            await _service.UpdateAsync(id, theater);
            return RedirectToAction(nameof(Index));
        }

        //GET: producers/delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var theaterDetails = await _service.GetByIdAsync(id);
            if (theaterDetails == null) return View("NotFound");
            return View(theaterDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var theaterDetails = await _service.GetByIdAsync(id);
            if (theaterDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
