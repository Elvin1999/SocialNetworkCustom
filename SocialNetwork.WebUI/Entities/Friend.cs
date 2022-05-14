using SocialNetwork.WebUI.DataAccess;

namespace SocialNetwork.WebUI.Entities
{
    public class Friend  : IEntity
    {
        public int Id { get; set; }
        public string MyId { get; set; }
        public string FriendId { get; set; }
    }
}
