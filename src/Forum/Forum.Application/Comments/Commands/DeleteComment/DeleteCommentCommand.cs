using MediatR;

namespace Forum.Application.Comments.Commands.DeleteComment;
public record DeleteCommentCommand : IRequest
{
    public Guid CommentId { get; init; }
}
