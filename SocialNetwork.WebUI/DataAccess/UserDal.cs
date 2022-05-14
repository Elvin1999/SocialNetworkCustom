using SocialNetwork.WebUI.Entities;
using System.Linq.Expressions;

namespace SocialNetwork.WebUI.DataAccess
{
    public class UserDal : IUserDal
    {

        private CustomeIdentityDbContext context;

        public UserDal(CustomeIdentityDbContext context)
        {
            this.context = context;
        }

        public void Add(CustomIdentityUser entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(CustomIdentityUser entity)
        {
            throw new NotImplementedException();
        }

        public CustomIdentityUser Get(Expression<Func<CustomIdentityUser, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CustomIdentityUser> GetList(Expression<Func<CustomIdentityUser, bool>> filter = null)
        {
            
                return filter == null
                    ? context.Set<CustomIdentityUser>().ToList()
                    : context.Set<CustomIdentityUser>().Where(filter).ToList();
            
        }

        public void Update(CustomIdentityUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
