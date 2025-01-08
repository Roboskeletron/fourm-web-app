using Forum.Application.Common.Exceptions;
using Forum.Application.Common.Intrefaces;
using Forum.Domain;
using Forum.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Forum.Application.Comments.Commands.UpdateComment;
public class UpdateCommentCommandHandler : IRequestHandler<UpdateCommentCommand>
{
    private readonly IApplicationDbContext _dbContext;
    private readonly IUserProvider _userProvider;

    public UpdateCommentCommandHandler(IApplicationDbContext dbContext, IUserProvider userProvider)
    {
        _dbContext = dbContext;
        _userProvider = userProvider;
    }

    public async Task Handle(UpdateCommentCommand command, CancellationToken cancellationToken)
    {
        var comment = await _dbContext.Comment
            .FirstOrDefaultAsync(x => x.Id == command.CommentId && !x.IsDeleted, cancellationToken)
            ?? throw new NotFoundException(nameof(Comment), command.CommentId);

        if (comment.AuthorId != _userProvider.User!.Id)
        {
            throw new ForbiddenAccessException();
        }

        comment.Text = command.Text;
        comment.UpdatedAt = DateTime.UtcNow;

        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
