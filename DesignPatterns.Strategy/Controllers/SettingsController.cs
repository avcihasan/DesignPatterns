using DesignPatterns.Strategy.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace DesignPatterns.Strategy.Controllers
{
    public class SettingsController : Controller
    {
        readonly UserManager<AppUser> _userManager;
        readonly SignInManager<AppUser> _signInManager;

        public SettingsController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            Settings settings = new();
            if (User.Claims.Where(x => x.Type == Settings.ClaimDatabaseType).FirstOrDefault() is not null)
                settings.DatabaseType = (DatabaseType)Convert.ToInt32(User.Claims.First(x => x.Type == Settings.ClaimDatabaseType).Value);
            else
                settings.DatabaseType = settings.DefaultDatabaseType;
            return View(settings);
        }

        [HttpPost]
        public async Task<IActionResult> ChangeDatabase(int databaseType)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var newClaim = new Claim(Settings.ClaimDatabaseType, databaseType.ToString());
            var claims = await _userManager.GetClaimsAsync(user);
            var hasDatabaseTypeClaim = claims.FirstOrDefault(x => x.Type == Settings.ClaimDatabaseType);
            if (hasDatabaseTypeClaim != null)
                await _userManager.ReplaceClaimAsync(user, hasDatabaseTypeClaim, newClaim);
            else
                await _userManager.AddClaimAsync(user, newClaim);
            await _signInManager.SignOutAsync();
            var authenticateResult = await HttpContext.AuthenticateAsync();
            await _signInManager.SignInAsync(user, authenticateResult.Properties);
            return RedirectToAction(nameof(Index));

        }
    }
}
