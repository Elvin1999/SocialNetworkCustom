using Microsoft.AspNetCore.Identity;

namespace SocialNetwork.WebUI.Entities
{
    public class CustomIdentityUser :IdentityUser
    {
        public string ImageUrl { get; set; }
    }
}
