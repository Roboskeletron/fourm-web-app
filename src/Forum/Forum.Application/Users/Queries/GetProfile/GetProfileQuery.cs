using Forum.Application.Common.Models;
using MediatR;

namespace Forum.Application.Users.Queries.GetProfile;
public record GetProfileQuery : IRequest<UserDto>
{
}
