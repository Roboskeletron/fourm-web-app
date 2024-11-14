using MediatR;

namespace Forum.Application.Messages.Commands.DeleteMessage;
public record DeleteMessageCommand : IRequest
{
    public Guid MessageId { get; init; }
}
