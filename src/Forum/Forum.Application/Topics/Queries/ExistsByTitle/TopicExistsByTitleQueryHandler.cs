using Forum.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Forum.Application.Topics.Queries.ExistsByTitle;
public class TopicExistsByTitleQueryHandler : IRequestHandler<TopicExistsByTitleQuery, bool>
{
    private readonly IApplicationDbContext _dbContext;

    public TopicExistsByTitleQueryHandler(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> Handle(TopicExistsByTitleQuery request, CancellationToken cancellationToken)
    {
        return await _dbContext.Topic.AnyAsync(x => x.Title == request.Title && !x.IsDeleted, cancellationToken);
    }
}
