using MediatR;

namespace Forum.Application.Topics.Commands.CreateTopic;
public record CreateTopicCommand : IRequest<Guid>
{
    public required string Title { get; init; }

    public string? Description { get; init; }
}
