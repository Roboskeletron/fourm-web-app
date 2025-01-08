using Forum.Application.Common.Exceptions;
using Forum.Application.Common.Intrefaces;
using Forum.Domain;
using Forum.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Forum.Application.Comments.Commands.DeleteComment;
public class DeleteCommentCommandHandler : IRequestHandler<DeleteCommentCommand>
{
    private readonly IApplicationDbContext _dbContext;
    private readonly IUserProvider _userProvider;

    public DeleteCommentCommandHandler(IApplicationDbContext dbContext, IUserProvider userProvider)
    {
        _dbContext = dbContext;
        _userProvider = userProvider;
    }

    public async Task Handle(DeleteCommentCommand command, CancellationToken cancellationToken)
    {
        var comment = await _dbContext.Comment
            .FirstOrDefaultAsync(x => x.Id == command.CommentId && !x.IsDeleted, cancellationToken)
            ?? throw new NotFoundException(nameof(Comment), command.CommentId);

        if (comment.AuthorId != _userProvider.User!.Id)
        {
            throw new ForbiddenAccessException();
        }

        comment.IsDeleted = true;

        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
