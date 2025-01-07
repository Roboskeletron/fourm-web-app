using Forum.Application.Common.Exceptions;
using Forum.Application.Common.Intrefaces;
using Forum.Application.Common.Models;
using Forum.Domain;
using Forum.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Forum.Application.Topics.Commands.LikeTopic;
public class LikeTopicCommandHandler : IRequestHandler<LikeTopicCommand, TopicDto>
{
    private readonly IApplicationDbContext _dbContext;
    private readonly IUserProvider _userProvider;

    public LikeTopicCommandHandler(IApplicationDbContext dbContext, IUserProvider userProvider)
    {
        _dbContext = dbContext;
        _userProvider = userProvider;
    }

    public async Task<TopicDto> Handle(LikeTopicCommand request, CancellationToken cancellationToken)
    {
        var topic = await _dbContext.Topic
            .Include(x => x.Likes)
            .Include(x => x.Author)
            .FirstOrDefaultAsync(x => x.Author.Id == _userProvider.User!.Id && !x.IsDeleted, cancellationToken)
            ?? throw new NotFoundException(nameof(Topic), request.TopicId);

        if (topic.Likes.Any(x => x.UserId == _userProvider.User!.Id))
        {
            throw new InvalidOperationException($"Topic {topic.Id} is already liked by user {_userProvider.User!.Id}");
        }

        var like = new TopicLike
        {
            UserId = _userProvider.User!.Id,
        };

        topic.Likes.Add(like);

        await _dbContext.SaveChangesAsync(cancellationToken);

        return new TopicDto
        {
            Id = topic.Id,
            AuthorId = topic.Author.Id,
            Description = topic.Description,
            Title = topic.Title,
            LikeCount = topic.Likes.Count,
            CanLike = false,
        };
    }
}
