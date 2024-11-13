using AutoMapper;
using Forum.Application.Topics.Commands.CreateTopic;
using Forum.Domain.Entities;

namespace Forum.Application.Common.Mappings;
public class TopicMappingProfile : Profile
{
    public TopicMappingProfile()
    {
        CreateMap<CreateTopicCommand, Topic>();
    }
}
