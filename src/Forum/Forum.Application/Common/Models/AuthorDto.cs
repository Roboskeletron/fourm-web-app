namespace Forum.Application.Common.Models;
public record AuthorDto
{
    public Guid Id { get; init; }

    public required string Name { get; init; }

    public Guid? AvatarId { get; init; }
}
