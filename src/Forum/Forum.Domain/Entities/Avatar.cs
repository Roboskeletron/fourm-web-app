namespace Forum.Domain.Entities;
public class Avatar
{
    public Guid Id { get; set; }

    public required byte[] Data { get; set; }

    public Guid UserId { get; set; }
}
