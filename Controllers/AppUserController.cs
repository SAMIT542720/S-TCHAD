using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using S_TCHAD.Data;
using S_TCHAD.Data.Static;
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
        //log out function
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        //access denied
        public IActionResult AccessDenied(string ReturnUrl)
        {
            return View();
        }
        //LISTING ALL USERS
        public async Task<IActionResult> Users()
        {
            var users = await _context.Users.ToListAsync();
            return View(users);
        }
        //REGISTER NEW USER
        public IActionResult Register() => View(new RegisterVM());

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid) return View(registerVM);

            var User = await _userManager.FindByEmailAsync(registerVM.EmialAddress);
            if (User != null)
            {
                TempData["Error"] = "هذا البريد الإلكتروني قيد الاستخدام بالفعل";
                return View(registerVM);
            }

            var newUser = new AppUser()
            {
                FullName = registerVM.FullName,
                Email = registerVM.EmialAddress,
                UserName = registerVM.EmialAddress
            };
            var newUserResponse = await _userManager.CreateAsync(newUser, registerVM.Password);

            if (newUserResponse.Succeeded)
                await _userManager.AddToRoleAsync(newUser, UserRoles.User);

            return View("RegisterCompleted");
        }
    }
}
