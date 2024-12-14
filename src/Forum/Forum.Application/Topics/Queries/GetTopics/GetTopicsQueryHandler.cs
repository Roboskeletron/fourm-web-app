using Forum.Application.Common.Extensions;
using Forum.Application.Common.Models;
using Forum.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Forum.Application.Topics.Queries.GetTopics;
public class GetTopicsQueryHandler : IRequestHandler<GetTopicsQuery, PagedList<TopicDto>>
{
    private readonly IApplicationDbContext _dbContext;

    public GetTopicsQueryHandler(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<PagedList<TopicDto>> Handle(GetTopicsQuery request, CancellationToken cancellationToken)
    {
        return await _dbContext.Topic
            .Where(x => string.IsNullOrWhiteSpace(request.SearchQuery) || EF.Functions.Like(x.Title, $"%{request.SearchQuery}%"))
            .Select(x => new TopicDto
            {
                Id = x.Id,
                Title = x.Title,
                AuthorId = x.UserId,
                Description = x.Description,
                UserCount = _dbContext.Message
                    .Where(m => m.TopicId == x.Id)
                    .Select(m => m.UserId)
                    .Distinct()
                    .Count(),
            })
            .OrderBy(x => x.Title)
            .AsNoTracking()
            .ToPagedListAsync(request.Pagination, cancellationToken);
    }
}
