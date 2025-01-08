using MediatR;

namespace Forum.Application.Topics.Commands.DeleteTopic;
public record DeleteTopicCommand : IRequest
{
    public Guid TopicId { get; init; }
}
