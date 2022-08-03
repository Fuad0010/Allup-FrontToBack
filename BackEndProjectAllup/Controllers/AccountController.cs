using BackEndProjectAllup.Models;
using BackEndProjectAllup.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace BackEndProjectAllup.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;


        public AccountController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid) return View();

            AppUser user = new AppUser
            {
                Fullname = registerVM.Fullname,
                UserName = registerVM.Name,
                Email = registerVM.Email,

            };

           IdentityResult result = await _userManager.CreateAsync(user,registerVM.Password);

            if (!result.Succeeded)
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View(registerVM);
            }

            await _signInManager.SignInAsync(user, true);

            return RedirectToAction("Index","Home");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid) return View();

            AppUser appUser = _userManager.FindByEmailAsync(login.Email).Result;
            if(appUser == null)
            {
                ModelState.AddModelError("","Email or Password is invalid :(");
                return View(login);
            }

            SignInResult result = await _signInManager.PasswordSignInAsync(appUser,login.Password,true,true);

            if (result.IsLockedOut)
            {
                ModelState.AddModelError("", "This account Locked :(");
                return View(login);
            }

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Email or Password is invalid :(");
                return View(login);
            }


            return RedirectToAction("index","home");
        }
    }
}
