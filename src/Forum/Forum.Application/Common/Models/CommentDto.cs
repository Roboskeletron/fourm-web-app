namespace Forum.Application.Common.Models;
public record CommentDto
{
    public Guid Id { get; init; }

    public required string Text { get; init; }

    public required AuthorDto Author { get; init; }

    public Guid MessageId { get; init; }

    public DateTime CreatedAt { get; init; }

    public DateTime UpdatedAt { get; init; }
}
