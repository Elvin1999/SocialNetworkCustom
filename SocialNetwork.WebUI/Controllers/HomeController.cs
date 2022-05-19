using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.WebUI.Entities;
using System.Security.Claims;

namespace SocialNetwork.WebUI.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {

        private UserManager<CustomIdentityUser> _userManager;
        public HomeController(UserManager<CustomIdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var users = _userManager.Users.ToList();
            return View(users);
        }
    }
}
