using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using S_TCHAD.Data;
using S_TCHAD.Data.VIEWMODELS;
using S_TCHAD.Models;

namespace S_TCHAD.Controllers
{
    public class AppUserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly AppDbContext _context;
        public AppUserController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, AppDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        //LOG IN FUNCTION
        public IActionResult Login() => View(new LoginVM());
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid) return View(loginVM);
            var user = await _userManager.FindByEmailAsync(loginVM.EmialAddress);
            if (user != null)
            {
                var passowrdcheck = await _userManager.CheckPasswordAsync(user, loginVM.Password);
                if (passowrdcheck)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                TempData["Error"] = "كلمة السر غير صحيحة. من فضلك حاول مرة اخري";
                return View(loginVM);
            }
            TempData["Error"] = "بيانات اعتماد خاطئة ، يرجى المحاولة مرة أخرى";
            return View(loginVM);
        }
    }
}
