using Microsoft.AspNetCore.Identity;

namespace SocialNetwork.WebUI.Entities
{
    public class CustomIdentityUser :IdentityUser
    {
        public CustomIdentityUser()
        {
            Messages = new List<Message>();
        }
        public virtual ICollection<Message> Messages { get; set; }
        public string ImageUrl { get; set; }
        public bool IsOnline { get; set; }
    }
}
