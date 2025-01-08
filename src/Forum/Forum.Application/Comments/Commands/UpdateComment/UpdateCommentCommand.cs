using MediatR;

namespace Forum.Application.Comments.Commands.UpdateComment;
public record UpdateCommentCommand : IRequest
{
    public Guid CommentId { get; init; }

    public required string Text { get; init; }
}
