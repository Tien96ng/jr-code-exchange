using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using CodeExchange.ViewModels;
using CodeExchange.Models;

namespace CodeExchange.Models
{
  public class AccountController : Controller
  {
    private readonly CodeExchangeContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountController (UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, CodeExchangeContext db)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }

    public IActionResult Register()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Register(RegisterViewModel model)
    {
      var email = new ApplicationUser { UserName = model.Email };
      IdentityResult result = await _userManager.CreateAsync(email, model.Password);
      if(result.Succeeded)
      {
        return RedirectToAction("Index", "Home");
      }
      else
      {
        return View();
      }
    }

    public ActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Login(LoginViewModel model)
    {
      Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
      if(result.Succeeded)
      {
        return RedirectToAction("Index", "Home");
      }
      else
      {
        return View();
      }
    }

    [HttpPost]
    public async Task<ActionResult> LogOff()
    {
      await _signInManager.SignOutAsync();
      return RedirectToAction("Index", "Home");
    }
  }
}