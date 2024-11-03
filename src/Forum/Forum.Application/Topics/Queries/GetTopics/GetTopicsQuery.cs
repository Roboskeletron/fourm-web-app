using Forum.Application.Common.Models;
using MediatR;

namespace Forum.Application.Topics.Queries.GetTopics;
public record GetTopicsQuery : IRequest<PagedList<TopicDto>>
{
    public string? SearchQuery { get; init; }

    public required PaginationParameters Pagination { get; init; }
}
