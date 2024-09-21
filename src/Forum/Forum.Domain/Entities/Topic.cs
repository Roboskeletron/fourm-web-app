namespace Forum.Domain.Entities;
public class Topic
{
    public Guid Id { get; set; }

    public required string Title { get; set; }

    public string? Description { get; set; }

    public Guid CreatedBy { get; set; }
}
