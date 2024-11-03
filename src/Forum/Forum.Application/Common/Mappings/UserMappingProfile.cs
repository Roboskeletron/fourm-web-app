using AutoMapper;
using Forum.Application.Common.Models;
using Forum.Domain.Entities;

namespace Forum.Application.Common.Mappings;
public class UserMappingProfile : Profile
{
    public UserMappingProfile()
    {
        CreateMap<User, UserDto>();
    }
}
