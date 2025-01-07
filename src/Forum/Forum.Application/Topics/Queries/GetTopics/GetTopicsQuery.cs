using Forum.Application.Common.Models;
using MediatR;

namespace Forum.Application.Topics.Queries.GetTopics;
public record GetTopicsQuery : IRequest<PagedList<TopicDto>>
{
    public string? Author { get; init; }

    public string? Title { get; init; }

    public string? Content { get; init; }

    public required PaginationParameters Pagination { get; init; }
}
