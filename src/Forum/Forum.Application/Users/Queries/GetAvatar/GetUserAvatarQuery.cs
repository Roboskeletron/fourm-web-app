using Forum.Domain.Entities;
using MediatR;

namespace Forum.Application.Users.Queries.GetAvatar;
public record GetUserAvatarQuery : IRequest<Avatar?>
{
    public Guid UserId { get; init; }
}
