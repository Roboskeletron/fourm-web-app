namespace Forum.Application.Common.Models;
public record MessageDto
{
    public Guid Id { get; init; }

    public required string Text { get; init; }

    public DateTime CreatedAt { get; init; }

    public DateTime UpdatedAt { get; init; }

    public Guid TopicId { get; init; }

    public required AuthorDto Author { get; init; }

    public long LikeCount { get; init; }

    public bool CanLike { get; init; }

    public long CommentCount { get; init; }
}
