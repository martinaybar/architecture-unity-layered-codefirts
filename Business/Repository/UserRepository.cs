using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interface;
using Data.Entities;
using Business.Repository;
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
            var user = GetAll().FirstOrDefault(x => x.UserId == userId);
            var query = Context.Set<User>().FirstOrDefault(x => x.UserId == userId);
            return query;
        }
    }
}
