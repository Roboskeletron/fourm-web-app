using MediatR;

namespace Forum.Application.Messages.Commands.AddComment;
public record AddMessageCommentCommand : IRequest<Guid>
{
    public Guid MessageId { get; init; }

    public required string Comment { get; init; }
}
