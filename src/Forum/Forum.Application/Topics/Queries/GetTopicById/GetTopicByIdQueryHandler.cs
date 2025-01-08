using Forum.Application.Common.Exceptions;
using Forum.Application.Common.Intrefaces;
using Forum.Application.Common.Models;
using Forum.Domain;
using Forum.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Forum.Application.Topics.Queries.GetTopicById;
public class GetTopicByIdQueryHandler : IRequestHandler<GetTopicByIdQuery, TopicDto>
{
    private readonly IApplicationDbContext _dbContext;
    private readonly IUserProvider _userProvider;

    public GetTopicByIdQueryHandler(IApplicationDbContext dbContext, IUserProvider userProvider)
    {
        _dbContext = dbContext;
        _userProvider = userProvider;
    }

    public async Task<TopicDto> Handle(GetTopicByIdQuery request, CancellationToken cancellationToken)
    {
        return await _dbContext.Topic
            .Where(x => !x.IsDeleted)
            .Select(x => new TopicDto
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                AuthorId = x.Author.Id,
                LikeCount = x.Likes.Count,
                CanLike = _userProvider.User == null || !x.Likes.Any(x => x.UserId == _userProvider.User.Id),
            })
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == request.TopicId, cancellationToken)
                ?? throw new NotFoundException(nameof(Topic), request.TopicId);
    }
}
