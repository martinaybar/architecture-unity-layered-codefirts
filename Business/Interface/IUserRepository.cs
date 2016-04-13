using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
namespace Business.Interface
{
    public interface IUserRepository: IGenericRepository<User>
    {
        User FindById(int userId);
    }
}
