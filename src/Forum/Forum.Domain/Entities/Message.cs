﻿namespace Forum.Domain.Entities;
public class Message
{
    public long Id { get; set; }

    public required string Text { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
