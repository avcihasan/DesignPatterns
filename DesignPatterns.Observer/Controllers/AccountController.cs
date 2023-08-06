using DesignPatterns.Observer.Models;
using DesignPatterns.Observer.Observers;
using DesignPatterns.Strategy.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Strategy.Controllers
{
    public class AccountController : Controller
    {
         readonly UserManager<AppUser> _userManager;
         readonly SignInManager<AppUser> _signInManager;
        readonly UserObserverSubject _userObserverSubject;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, UserObserverSubject userObserverSubject)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _userObserverSubject = userObserverSubject;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            var hasUser = await _userManager.FindByEmailAsync(email);

            if (hasUser == null) return View();

            var signInResult = await _signInManager.PasswordSignInAsync(hasUser, password, true, false);

            if (!signInResult.Succeeded)
                return View();

            return RedirectToAction(nameof(HomeController.Index), "Home");

        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }


        public  IActionResult SignUp()
        {
            return View(); ;
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(CreateUserVM createUserVM)
        {
            AppUser user = new() { Id=Guid.NewGuid().ToString(),Email = createUserVM.Email, UserName = createUserVM.UserName };
            IdentityResult result = await _userManager.CreateAsync(user,createUserVM.Password);
            if (result.Succeeded)
            {
                _userObserverSubject.NotifyObserver(user);
                ViewBag.message = "Kayıt Başarılı";
            }
            else
                ViewBag.message = result.Errors.First().Description;

            return View(); ;
        }
    }
}
