﻿namespace Forum.Domain.Entities;
public class Topic
{
    public Guid Id { get; set; }

    public required string Title { get; set; }

    public string? Description { get; set; }

    public Guid UserId { get; set; }

    public User Author { get; set; }

    public List<TopicLike> Likes { get; set; } = [];

    public bool IsDeleted { get; set; }

    public const int TitleMaxLength = 25;

    public const int DescriptionMaxLength = 1000;
}
