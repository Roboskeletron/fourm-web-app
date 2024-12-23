using Forum.Application.Common.Exceptions;
using Forum.Application.Common.Intrefaces;
using Forum.Domain;
using Forum.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Forum.Application.Topics.Commands.UpdateTopic;
public class UpdateTopicCommandHandler : IRequestHandler<UpdateTopicCommand>
{
    private readonly IApplicationDbContext _dbContext;
    private readonly IUserProvider _userProvider;

    public UpdateTopicCommandHandler(IApplicationDbContext dbContext, IUserProvider userProvider)
    {
        _dbContext = dbContext;
        _userProvider = userProvider;
    }

    public async Task Handle(UpdateTopicCommand request, CancellationToken cancellationToken)
    {
        var topic = await _dbContext.Topic
            .FirstOrDefaultAsync(x => x.Id == request.TopicId, cancellationToken)
            ?? throw new NotFoundException(nameof(Topic), request.TopicId);

        if (topic.UserId != _userProvider.User!.Id)
        {
            throw new ForbiddenAccessException();
        }

        var isTitleExists = await _dbContext.Topic.AnyAsync(x => x.Title == request.Title && x.Id != request.TopicId, cancellationToken);

        if (isTitleExists)
        {
            throw new ArgumentException();
        }

        topic.Title = request.Title;
        topic.Description = request.Description;

        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
