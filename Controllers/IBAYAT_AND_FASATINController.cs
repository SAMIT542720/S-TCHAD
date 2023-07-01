using Microsoft.AspNetCore.Authorization;
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
            if (actorDetails == null) return View("NotFound");
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
        // [HttpGet]
        //public async Task<IActionResult> WhatsAppMessage(int id)
        //{
        //    // Retrieve the product details by ID from the database or any other source
        //    var product = _service.GetByIdAsync(id); // Replace this with your logic to get the product details

        //    if (product != null)
        //    {
        //        var whatsappNumber = "+235 66 65 05 39"; // Replace with your actual WhatsApp number
        //        var message = $"Product Name: {product.Name}%0AProduct Description: {product.Description}"; // URL encoded message

        //        var whatsappUrl = $"https://wa.me/{whatsappNumber}?text={message}";
        //        return Redirect(whatsappUrl);
        //    }

        //    // Handle case where product is not found
        //    return NotFound();
        //}

    }
}
