using Forum.Application.Common.Models;
using MediatR;

namespace Forum.Application.Topics.Commands.LikeTopic;
public record LikeTopicCommand : IRequest<TopicDto>
{
    public Guid TopicId { get; init; }
}
