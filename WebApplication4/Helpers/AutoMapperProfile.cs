using AutoMapper;
using WebApplication4.Dtos;
using WebApplication4.Entities;

namespace WebApplication4.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}
