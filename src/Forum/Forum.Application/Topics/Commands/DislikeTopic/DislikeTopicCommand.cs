using Forum.Application.Common.Models;
using MediatR;

namespace Forum.Application.Topics.Commands.DislikeTopic;
public record DislikeTopicCommand : IRequest<TopicDto>
{
    public Guid TopicId { get; init; }
}
