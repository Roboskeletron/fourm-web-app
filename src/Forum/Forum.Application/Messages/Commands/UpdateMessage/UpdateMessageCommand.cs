using MediatR;

namespace Forum.Application.Messages.Commands.UpdateMessage;
public record UpdateMessageCommand : IRequest
{
    public Guid MessageId { get; init; }

    public required string Text { get; init; }
}
