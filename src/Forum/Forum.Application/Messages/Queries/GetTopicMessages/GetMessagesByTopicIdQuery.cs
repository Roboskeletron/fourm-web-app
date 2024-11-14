using Forum.Application.Common.Models;
using MediatR;

namespace Forum.Application.Messages.Queries.GetTopicMessages;
public record GetMessagesByTopicIdQuery : IRequest<PagedList<MessageDto>>
{
    public Guid TopicId { get; init; }

    public required PaginationParameters Pagination { get; init; }

    public string? SearchQuery { get; init; }
}
