using Forum.Application.Common.Exceptions;
using Forum.Application.Common.Intrefaces;
using Forum.Domain;
using Forum.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Forum.Application.Comments.Commands.CreateComment;
public class CreateMessageCommentCommandHandler : IRequestHandler<CreateMessageCommentCommand, Guid>
{
    private readonly IUserProvider _userProvider;
    private readonly IApplicationDbContext _dbContext;

    public CreateMessageCommentCommandHandler(IUserProvider userProvider, IApplicationDbContext dbContext)
    {
        _userProvider = userProvider;
        _dbContext = dbContext;
    }

    public async Task<Guid> Handle(CreateMessageCommentCommand command, CancellationToken cancellationToken)
    {
        var message = await _dbContext.Message
            .FirstOrDefaultAsync(x => x.Id == command.MessageId && !x.IsDeleted, cancellationToken)
            ?? throw new NotFoundException(nameof(Message), command.MessageId);

        var comment = new Comment
        {
            Text = command.Comment,
            AuthorId = _userProvider.User!.Id,
            CreatedAt = DateTime.UtcNow,
        };

        message.Comments.Add(comment);

        await _dbContext.SaveChangesAsync(cancellationToken);

        return comment.Id;
    }
}
