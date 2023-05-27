﻿using Microsoft.AspNetCore.Mvc;
using S_TCHAD.Data.Service;
using S_TCHAD.Models;

namespace S_TCHAD.Controllers
{
    public class WomenShooeseController : Controller
    {
        private readonly IWomenShooeseService _service;
        public WomenShooeseController(IWomenShooeseService service)
        {
            _service = service;
        }
        //list of all products
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }
        //details of the product
        public async Task<IActionResult> Details(int id)
        {
            var actordetails = await _service.GetByIdAsync(id);
            if (actordetails == null) { return View("Not Found"); }
            return View(actordetails);
        }
        //add new product.
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name, PhotoURL1,PhotoURL2,PhotoURL3,Description,Sex")] WomenShooese abaya)
        {
            if (!ModelState.IsValid)
            {
                return View(abaya);
            }
            await _service.AddAsync(abaya);
            return RedirectToAction(nameof(Index));
        }
        //edit product
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Name, PhotoURL1,PhotoURL2,PhotoURL3,Description,Sex")] WomenShooese abaya)
        {
            if (!ModelState.IsValid)
            {
                return View(abaya);
            }
            await _service.UpdateAsync(id, abaya);
            return RedirectToAction(nameof(Index));
        }
        //delet a product
        public async Task<IActionResult> Delete(int id)
        {
            var pdatails = await _service.GetByIdAsync(id);
            if (pdatails == null) return View("NotFound");
            return View(pdatails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pdatails = await _service.GetByIdAsync(id);
            if (pdatails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
