using MediatR;

namespace Forum.Application.Users.Commands.UpdateProfile;
public record UpdateProfileCommand : IRequest
{
    public required string Name { get; init; }

    public string? Description { get; init; }

    public Guid? AvatarId { get; init; }
}

