using Forum.Application.Common.Exceptions;
using Forum.Application.Common.Models;
using Forum.Domain;
using Forum.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Forum.Application.Topics.Queries.GetTopicById;
public class GetTopicByIdQueryHandler : IRequestHandler<GetTopicByIdQuery, TopicDto>
{
    private readonly IApplicationDbContext _dbContext;

    public GetTopicByIdQueryHandler(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<TopicDto> Handle(GetTopicByIdQuery request, CancellationToken cancellationToken)
    {
        return await _dbContext.Topic
            .Select(x => new TopicDto
            {
                Id = x.Id,
                Title = x.Title,
                AuthorId = x.Author.Id,
                UserCount = _dbContext.Message.Where(m => m.TopicId == x.Id).Count(),
            })
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == request.TopicId, cancellationToken)
                ?? throw new NotFoundException(nameof(Topic), request.TopicId);
    }
}
