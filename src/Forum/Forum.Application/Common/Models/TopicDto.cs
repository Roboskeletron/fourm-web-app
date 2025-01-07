namespace Forum.Application.Common.Models;
public record TopicDto
{
    public Guid Id { get; init; }

    public required string Title { get; init; }

    public string? Description { get; init; }

    public Guid AuthorId { get; init; }

    public long LikeCount { get; init; }
}
