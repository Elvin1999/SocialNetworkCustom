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

        public ChatHub(UserManager<CustomIdentityUser> userManager)
        {
            this.userManager = userManager;
            
        }

        public async Task SendMessage(string user, string message)
        {
            var currentUser = UserHelper.CurrentUser;

            await Clients.All.SendAsync("ReceiveMessage", currentUser.UserName, message);
        }



        public override async Task OnConnectedAsync()
        {
            
            string info = " connected successfully";
            await Clients.Others.SendAsync("Connect", info);
        }

    }
}
