using System.Linq;
using Business.Interface;
using Entities;
using Data.Context;

namespace Business.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(DataContext context)
            :base(context)
        {
        }

        public User FindById(int userId)
        {
            //var user = GetAll().FirstOrDefault(x => x.UserId == userId);
            var query = Context.Set<User>().FirstOrDefault(x => x.UserId == userId);
            return query;
        }
    }
}
