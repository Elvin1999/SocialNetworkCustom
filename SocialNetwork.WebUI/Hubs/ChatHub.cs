using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using SocialNetwork.WebUI.Entities;
using SocialNetwork.WebUI.Helpers;

namespace SocialNetwork.WebUI.Hubs
{
    public class ChatHub : Hub
    {
        private UserManager<CustomIdentityUser> userManager;
        private IHttpContextAccessor httpContextAccessor;

        public ChatHub(UserManager<CustomIdentityUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            this.userManager = userManager;
            this.httpContextAccessor = httpContextAccessor;
        }

        public async Task SendMessage(string user, string message)
        {
            var currentUser = await userManager.GetUserAsync(httpContextAccessor.HttpContext.User);

            await Clients.All.SendAsync("ReceiveMessage", currentUser, message);
        }



        public override async Task OnConnectedAsync()
        {
            
            string info = " connected successfully";
            await Clients.Others.SendAsync("Connect", info);
        }

    }
}
