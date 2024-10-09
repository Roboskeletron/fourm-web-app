namespace Forum.Domain.Entities;
public class Message
{
    public Guid Id { get; set; }

    public required string Text { get; set; }

    public Guid UserId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public bool IsDeleted { get; set; }

    public required User Author { get; set; }

    public List<Like> Likes { get; set; } = [];

    public List<File> Files { get; set; } = [];

    public const int TextMaxLength = 1000;
}
