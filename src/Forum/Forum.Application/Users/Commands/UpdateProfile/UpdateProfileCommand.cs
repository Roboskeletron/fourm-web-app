using MediatR;
using Microsoft.AspNetCore.Http;

namespace Forum.Application.Users.Commands.UpdateProfile;
public record UpdateProfileCommand : IRequest
{
    public required string Name { get; init; }

    public string? Description { get; init; }

    public IFormFile? Avatar { get; init; }
}

