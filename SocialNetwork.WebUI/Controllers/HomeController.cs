using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.WebUI.Entities;
using SocialNetwork.WebUI.Helpers;
using System.Security.Claims;

namespace SocialNetwork.WebUI.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {

        private UserManager<CustomIdentityUser> _userManager;
        private IHttpContextAccessor _httpContextAccessor;

        public HomeController(UserManager<CustomIdentityUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<IActionResult> Index()
        {

            var user = await _userManager.GetUserAsync(HttpContext.User);
            ViewBag.User = user;
            var users = _userManager.Users.Where(u=>u.Id!=user.Id).ToList();
            return View(users);
        }

        public async Task<IActionResult> FindCurrentUser(string id)
        {
            UserHelper.ReceiverUser = _userManager.Users.FirstOrDefault(u=>u.Id==id);

            return RedirectToAction("Index");
           // UserHelper.CurrentUser = _userManager.GetUserAsync();
        }
    }
}
