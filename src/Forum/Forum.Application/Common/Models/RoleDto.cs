namespace Forum.Application.Common.Models;
public record RoleDto
{
    public int RoleId { get; init; }

    public required string Name { get; init; }
}
