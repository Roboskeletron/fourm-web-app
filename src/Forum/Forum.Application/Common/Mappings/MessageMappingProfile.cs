using AutoMapper;
using Forum.Application.Common.Models;
using Forum.Application.Messages.Commands.CreateMessage;
using Forum.Domain.Entities;

namespace Forum.Application.Common.Mappings;
public class MessageMappingProfile : Profile
{
    public MessageMappingProfile()
    {
        CreateMap<Message, MessageDto>();
        CreateMap<CreateMessageCommand, Message>();
    }
}
