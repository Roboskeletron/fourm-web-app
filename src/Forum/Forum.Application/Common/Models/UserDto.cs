namespace Forum.Application.Common.Models;
public record UserDto
{
    public Guid Id { get; init; }

    public required string Name { get; init; }

    public required string Email { get; init; }

    public string? Description { get; init; }

    public DateTime CreatedAt { get; init; }

    public List<RoleDto> Roles { get; init; } = [];
}
