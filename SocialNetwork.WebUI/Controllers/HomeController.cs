using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.WebUI.Entities;
using SocialNetwork.WebUI.Helpers;
using SocialNetwork.WebUI.Models;
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
            UserHelper.CurrentUser = user;  
            ViewBag.User = user;
            var users = _userManager.Users.Where(u=>u.Id!=user.Id).ToList();
            foreach (var item in users)
            {
                var onlineUser = UserHelper.ActiveUsers.FirstOrDefault(u => u.Id == item.Id);
                if(onlineUser != null)
                {
                    item.IsOnline = true;
                }
            }
            var model = new HomeUserViewModel
            {
                AllUsers = users,
                ActiveUsers = UserHelper.ActiveUsers
            };
            return View(model);
        }

        public async Task<IActionResult> FindCurrentUser(string id)
        {
            UserHelper.ReceiverUser = _userManager.Users.FirstOrDefault(u=>u.Id==id);

            return RedirectToAction("Index");
           // UserHelper.CurrentUser = _userManager.GetUserAsync();
        }

        public async Task<IActionResult> GetAllActiveUsers()
        {
            return Ok(UserHelper.ActiveUsers.DistinctBy(u=>u.Id));
        }


    }
}
