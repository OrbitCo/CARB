using CAQM.Entities;
using WebApi.Dtos;
using AutoMapper;

namespace WebApi.Mappers
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
