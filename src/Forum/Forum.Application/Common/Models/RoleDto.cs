namespace Forum.Application.Common.Models;
public record RoleDto
{
    public int Id { get; init; }

    public required string Name { get; init; }
}
