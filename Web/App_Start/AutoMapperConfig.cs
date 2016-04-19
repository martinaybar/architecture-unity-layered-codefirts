using AutoMapper;
using Entities;
using Web.Models;


namespace Web
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            // Mapper.Initialize
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<User, UserVM>();
            });
        }
    }
}