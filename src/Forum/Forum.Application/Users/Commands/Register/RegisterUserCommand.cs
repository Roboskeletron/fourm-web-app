using MediatR;

namespace Forum.Application.Users.Commands.Register;
public record RegisterUserCommand : IRequest
{
    public required string Name { get; init; }

    public required string Email { get; init; }

    public required string Password { get; init; }
}
