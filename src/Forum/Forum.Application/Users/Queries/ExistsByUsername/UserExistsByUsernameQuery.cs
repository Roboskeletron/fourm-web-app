using MediatR;

namespace Forum.Application.Users.Queries.ExistsByUsername;
public record UserExistsByUsernameQuery : IRequest<bool>
{
    public required string Username { get; init; }
}
