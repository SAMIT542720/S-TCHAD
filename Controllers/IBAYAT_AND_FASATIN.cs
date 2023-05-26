using Microsoft.AspNetCore.Mvc;
using S_TCHAD.Data;
using S_TCHAD.Data.Service;

namespace S_TCHAD.Controllers
{
    public class IBAYAT_AND_FASATIN : Controller
    {
        private readonly IIBAYATSERVICE _service;

        public MOVIESController(IIBAYATSERVICE service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            var allMOVIES = await 
            return View(allMOVIES);
        }
    }
}
