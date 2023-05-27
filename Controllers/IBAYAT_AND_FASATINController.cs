using Microsoft.AspNetCore.Mvc;
using S_TCHAD.Data;
using S_TCHAD.Data.Service;
using S_TCHAD.Models;

namespace S_TCHAD.Controllers
{
    public class IBAYAT_AND_FASATINController : Controller
    {
        private readonly IIBAYATSERVICE _service;
        public IBAYAT_AND_FASATINController(IIBAYATSERVICE service)
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
        //create new actor.
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
    }
}
