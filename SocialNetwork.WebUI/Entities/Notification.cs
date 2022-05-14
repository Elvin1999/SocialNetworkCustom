using SocialNetwork.WebUI.DataAccess;

namespace SocialNetwork.WebUI.Entities
{
    public class Notification : IEntity
    {
        public int Id { get; set; }
        public string ReceiverId { get; set; }
        public virtual CustomIdentityUser Receiver { get; set; }
        public string SenderId { get; set; }
        public virtual CustomIdentityUser Sender { get; set; }

        public string Content { get; set; }
        public DateTime NotifyDateTime { get; set; }
    }
}
