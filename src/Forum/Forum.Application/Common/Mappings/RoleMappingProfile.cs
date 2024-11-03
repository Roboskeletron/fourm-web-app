using AutoMapper;
using Forum.Application.Common.Models;
using Forum.Domain.Entities;

namespace Forum.Application.Common.Mappings;
public class RoleMappingProfile : Profile
{
    public RoleMappingProfile()
    {
        CreateMap<Role, RoleDto>();
    }
}
