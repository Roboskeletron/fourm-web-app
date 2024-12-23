using MediatR;

namespace Forum.Application.Topics.Commands.UpdateTopic;
public record UpdateTopicCommand : IRequest
{
    public Guid TopicId { get; init; }

    public required string Title { get; init; }

    public string? Description { get; init; }
}
