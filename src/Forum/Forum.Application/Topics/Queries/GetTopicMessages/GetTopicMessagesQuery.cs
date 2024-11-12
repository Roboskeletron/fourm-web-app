using Forum.Application.Common.Models;
using MediatR;

namespace Forum.Application.Topics.Queries.GetTopicMessages;
public record GetTopicMessagesQuery : IRequest<PagedList<MessageDto>>
{
    public Guid TopicId { get; init; }

    public required PaginationParameters Pagination { get; init; }

    public string? SearchQuery { get; init; }
}
