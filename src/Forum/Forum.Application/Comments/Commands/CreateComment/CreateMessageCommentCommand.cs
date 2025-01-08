using MediatR;

namespace Forum.Application.Comments.Commands.CreateComment;
public record CreateMessageCommentCommand : IRequest<Guid>
{
    public Guid MessageId { get; init; }

    public required string Comment { get; init; }
}
