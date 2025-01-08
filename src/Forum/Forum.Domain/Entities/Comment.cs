namespace Forum.Domain.Entities;
public class Comment
{
    public Guid Id { get; set; }

    public Guid AuthorId { get; set; }

    public Guid MessageId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string Text { get; set; }

    public bool IsDeleted { get; set; }

    public const int CommentMaxLenght = 1000;
}
