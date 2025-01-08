namespace Forum.Domain.Entities;
public class Message
{
    public Guid Id { get; set; }

    public required string Text { get; set; }

    public required Guid TopicId { get; set; }

    public Guid UserId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public bool IsDeleted { get; set; }

    public User Author { get; set; }

    public List<MessageLike> Likes { get; set; } = [];

    public List<Comment> Comments { get; set; }

    public const int TextMaxLength = 1000;
}
