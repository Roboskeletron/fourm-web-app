using Forum.Application.Common.Exceptions;
using Forum.Application.Common.Intrefaces;
using Forum.Application.Common.Models;
using Forum.Domain;
using Forum.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Forum.Application.Topics.Commands.DislikeTopic;
public class DislikeTopicCommandHandler : IRequestHandler<DislikeTopicCommand, TopicDto>
{
    private readonly IApplicationDbContext _dbContext;
    private readonly IUserProvider _userProvider;

    public DislikeTopicCommandHandler(IApplicationDbContext dbContext, IUserProvider userProvider)
    {
        _dbContext = dbContext;
        _userProvider = userProvider;
    }

    public async Task<TopicDto> Handle(DislikeTopicCommand request, CancellationToken cancellationToken)
    {
        var topic = await _dbContext.Topic
            .Include(x => x.Likes)
            .Include(x => x.Author)
            .FirstOrDefaultAsync(x => x.Author.Id == _userProvider.User!.Id && !x.IsDeleted, cancellationToken)
            ?? throw new NotFoundException(nameof(Topic), request.TopicId);

        var like = topic.Likes.FirstOrDefault(x => x.UserId == _userProvider.User!.Id)
            ?? throw new InvalidOperationException($"Topic {topic.Id} is not liked by user {_userProvider.User!.Id}");

        topic.Likes.Remove(like);

        await _dbContext.SaveChangesAsync(cancellationToken);

        return new TopicDto
        {
            Id = topic.Id,
            AuthorId = topic.Author.Id,
            Description = topic.Description,
            Title = topic.Title,
            LikeCount = topic.Likes.Count,
            CanLike = true,
        };
    }
}
