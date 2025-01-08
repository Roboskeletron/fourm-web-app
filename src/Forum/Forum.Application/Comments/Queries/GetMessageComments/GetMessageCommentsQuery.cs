using Forum.Application.Common.Models;
using MediatR;

namespace Forum.Application.Comments.Queries.GetMessageComments;
public record GetMessageCommentsQuery : IRequest<PagedList<CommentDto>>
{
    public Guid MessageId { get; init; }

    public required PaginationParameters Pagination { get; init; }
}
