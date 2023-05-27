using Microsoft.AspNetCore.Mvc;
using S_TCHAD.Data;
using S_TCHAD.Data.Service;

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
    }
}
