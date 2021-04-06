using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using CodeExchange.Models;

namespace CodeExchange.Controllers
{
  [Authorize]
  public class HomeController : Controller
  {
    private readonly CodeExchangeContext _db;
    public HomeController(UserManager<ApplicationUser> userManager, CodeExchangeContext db)
    {
      _userManager = userManager;
      _db = db;
    }
    [AllowAnonymous]
    public ActionResult Index()
    {
      // Grab _Db of forums and Include Posts sorted by DateTime
      // Pass both into view. Forums will be integrated into sidebar 
      ICollection<Forum> model = _db.Forums.ToList();
      ViewBag.postByDate = _db.Posts.ToList().OrderByDescending(e => e.CreationDate);
      ViewBag.postByPopularity = _db.

      // (Implement on CSHTML) =
      // Scrolling list of most popular posts (stretch)
      // OR button at button to load next 10 most popular posts
      return View(model);
    }
  }
}