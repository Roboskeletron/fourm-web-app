using Forum.Application.Common.Exceptions;
using Forum.Application.Common.Intrefaces;
using Forum.Domain;
using Forum.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Forum.Application.Topics.Commands.DeleteTopic;
public class DeleteTopicCommandHandler : IRequestHandler<DeleteTopicCommand>
{
    private readonly IApplicationDbContext _dbContext;
    private readonly IUserProvider _userProvider;

    public DeleteTopicCommandHandler(IApplicationDbContext dbContext, IUserProvider userProvider)
    {
        _dbContext = dbContext;
        _userProvider = userProvider;
    }

    public async Task Handle(DeleteTopicCommand command, CancellationToken cancellationToken)
    {
        var topic = await _dbContext.Topic
            .FirstOrDefaultAsync(x => x.Id == command.TopicId && !x.IsDeleted, cancellationToken)
            ?? throw new NotFoundException(nameof(Topic), command.TopicId);

        if (topic.UserId != _userProvider.User!.Id)
        {
            throw new ForbiddenAccessException();
        }

        topic.IsDeleted = true;

        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
