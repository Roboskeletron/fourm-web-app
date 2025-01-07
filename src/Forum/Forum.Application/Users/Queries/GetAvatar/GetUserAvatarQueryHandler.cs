using Forum.Application.Common.Exceptions;
using Forum.Domain;
using Forum.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Forum.Application.Users.Queries.GetAvatar;
public class GetUserAvatarQueryHandler : IRequestHandler<GetUserAvatarQuery, Avatar?>
{
    private readonly IApplicationDbContext _dbContext;

    public GetUserAvatarQueryHandler(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Avatar?> Handle(GetUserAvatarQuery request, CancellationToken cancellationToken)
    {
        var user = await _dbContext.Users
            .Include(x => x.Avatar)
            .FirstOrDefaultAsync(x => x.Id == request.UserId, cancellationToken)
            ?? throw new NotFoundException(nameof(User), request.UserId);

        return user.Avatar;
    }
}
