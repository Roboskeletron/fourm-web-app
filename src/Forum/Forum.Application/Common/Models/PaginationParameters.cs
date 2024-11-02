namespace Forum.Application.Common.Models;
public record PaginationParameters
{
    public int PageNumber { get; init; }

    public int PageSize { get; init; }
}
