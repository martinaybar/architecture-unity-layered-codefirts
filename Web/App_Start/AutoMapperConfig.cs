using Entities;
using Web.Models;


namespace Web
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<User, UserVM>();
                cfg.CreateMap<UserVM, User>();
                cfg.CreateMap<UserTypeVM, UserType>();
                cfg.CreateMap<UserType, UserTypeVM>();
            });
        }
    }
}