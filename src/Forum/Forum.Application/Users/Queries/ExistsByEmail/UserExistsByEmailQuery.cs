using MediatR;

namespace Forum.Application.Users.Queries.ExistsByEmail;
public record UserExistsByEmailQuery : IRequest<bool>
{
    public required string Email { get; init; }
}
