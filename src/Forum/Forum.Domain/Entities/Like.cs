namespace Forum.Domain.Entities;
public class Like
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public Guid MessageId { get; set; }
}
