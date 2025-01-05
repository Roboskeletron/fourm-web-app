using Forum.Application.Common.Exceptions;
using Forum.Application.Common.Intrefaces;
using Forum.Domain;
using Forum.Domain.Entities;
using Forum.Domain.RBAC;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Forum.Application.Messages.Commands.DeleteMessage;
public class DeleteMessageCommandHandler : IRequestHandler<DeleteMessageCommand>
{
    private readonly IApplicationDbContext _dbContext;
    private readonly IUserProvider _userProvider;

    public DeleteMessageCommandHandler(IApplicationDbContext dbContext, IUserProvider userProvider)
    {
        _dbContext = dbContext;
        _userProvider = userProvider;
    }

    public async Task Handle(DeleteMessageCommand request, CancellationToken cancellationToken)
    {
        var message = await _dbContext.Message.FirstOrDefaultAsync(x => x.Id == request.MessageId && !x.IsDeleted, cancellationToken)
            ?? throw new NotFoundException(nameof(Message), request.MessageId);

        if (message.Author.Id != _userProvider.User!.Id
            && !_userProvider.User.Roles.Any(x => x.Id == Roles.Administrator.Id))
        {
            throw new ForbiddenAccessException();
        }

        message.IsDeleted = true;
        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
