namespace Forum.Domain.Entities;
public record TopicLike
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public Guid TopicId { get; set; }
}
