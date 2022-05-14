using Microsoft.AspNetCore.Identity;
using SocialNetwork.WebUI.DataAccess;

namespace SocialNetwork.WebUI.Entities
{
    public class CustomIdentityUser :IdentityUser, IEntity
    {
        public string ImageUrl { get; set; }     
    }
}
