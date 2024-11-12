using Forum.Application.Common.Models;
using Microsoft.EntityFrameworkCore;

namespace Forum.Application.Common.Extensions;
public static class PagedListExtensions
{
    public static async Task<PagedList<T>> ToPagedListAsync<T>(this IQueryable<T> query, PaginationParameters paginationParameters, CancellationToken cancellationToken = default) where T : class
    {
        var items = await query
            .Skip(paginationParameters.PageSize * (paginationParameters.PageNumber - 1))
            .Take(paginationParameters.PageSize)
            .ToListAsync(cancellationToken);

        return new PagedList<T>
        {
            Items = items,
            Count = items.Count,
        };
    }

    public static PagedList<T> ToPagedList<T>(this IEnumerable<T> items, PaginationParameters paginationParameters)
    {
        var itemsList = items
            .Skip(paginationParameters.PageSize * (paginationParameters.PageNumber - 1))
            .Take(paginationParameters.PageSize)
            .ToList();

        return new PagedList<T>
        {
            Items = itemsList,
            Count = itemsList.Count,
        };
    }
}
