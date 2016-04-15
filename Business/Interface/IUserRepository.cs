using Entities;


namespace Business.Interface
{
    public interface IUserRepository: IGenericRepository<User>
    {
        User FindById(int userId);
    }
}
