using Forum.Application.Common.Models;
using MediatR;

namespace Forum.Application.Users.Queries.GetUserById;
public record GetUserByIdQuery : IRequest<UserDto>
{
    public Guid UserId { get; init; }
}
