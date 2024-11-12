using AutoMapper;
using Forum.Application.Common.Models;
using Forum.Domain.Entities;

namespace Forum.Application.Common.Mappings;
public class MessageMappingProfile : Profile
{
    public MessageMappingProfile()
    {
        CreateMap<Message, MessageDto>();
    }
}
