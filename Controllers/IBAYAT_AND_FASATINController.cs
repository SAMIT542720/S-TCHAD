﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using S_TCHAD.Data;
using S_TCHAD.Data.Service;
using S_TCHAD.Data.Static;
using S_TCHAD.Data.VIEWMODELS;
using S_TCHAD.Models;
using System.Data;

namespace S_TCHAD.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class IBAYAT_AND_FASATINController : Controller
    {
        private readonly IIBAYATSERVICE _service;
        public IBAYAT_AND_FASATINController(IIBAYATSERVICE service)
        {
            _service = service;
        }
        //list of all products
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }
        //details of the product
        [AllowAnonymous]
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
        public async Task<IActionResult> Create([Bind("Name, PhotoURL1,PhotoURL2,PhotoURL3,Description,Sex")] IBAYAT_AND_FASATIN abaya)
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
            if (actorDetails == null) return View("Not Found");
            return View(actorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewProductVM movie)
        {
            if (id != movie.ID)
            {
                return View("Not Found");
            }
            await _service.UpdateProductAsync(movie);
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
        //serach for a product
        //public async Task<IActionResult> Filter(string searchString)
        //{
        //    var allMOVIES = await _service.GetAllAsync();
        //    if (!string.IsNullOrEmpty(searchString))
        //    {
        //        var filteredresult = allMOVIES.Where(n => n.Name.Contains(searchString)).ToList();
        //        return View("Index", filteredresult);
        //    }
        //    return View("Index", allMOVIES);
        //}
    }
}
