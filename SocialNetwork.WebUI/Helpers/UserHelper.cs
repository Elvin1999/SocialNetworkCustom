using SocialNetwork.WebUI.Entities;

namespace SocialNetwork.WebUI.Helpers
{
    public static class UserHelper
    {
        public static CustomIdentityUser CurrentUser { get; set; }
        public static CustomIdentityUser ReceiverUser { get; set; } 
    }
}
