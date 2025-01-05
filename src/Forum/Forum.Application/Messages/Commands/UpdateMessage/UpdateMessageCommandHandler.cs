using Forum.Application.Common.Exceptions;
using Forum.Application.Common.Intrefaces;
using Forum.Domain;
using Forum.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Forum.Application.Messages.Commands.UpdateMessage;
public class UpdateMessageCommandHandler : IRequestHandler<UpdateMessageCommand>
{
    private readonly IApplicationDbContext _dbContext;
    private readonly IUserProvider _userProvider;

    public UpdateMessageCommandHandler(IApplicationDbContext dbContext, IUserProvider userProvider)
    {
        _dbContext = dbContext;
        _userProvider = userProvider;
    }

    public async Task Handle(UpdateMessageCommand command, CancellationToken cancellationToken)
    {
        var message = await _dbContext.Message
            .Include(x => x.Author)
            .FirstOrDefaultAsync(x => x.Id == command.MessageId && !x.IsDeleted, cancellationToken)
            ?? throw new NotFoundException(nameof(Message), command.MessageId);

        if (message.Author.Id != _userProvider.User!.Id)
        {
            throw new ForbiddenAccessException();
        }

        message.Text = command.Text;

        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
