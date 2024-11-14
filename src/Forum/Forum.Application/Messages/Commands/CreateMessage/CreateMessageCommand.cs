using MediatR;

namespace Forum.Application.Messages.Commands.CreateMessage;
public record CreateMessageCommand : IRequest<Guid>
{
    public Guid TopicId { get; init; }

    public required string Text { get; init; }
}
