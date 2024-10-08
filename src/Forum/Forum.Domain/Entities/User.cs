﻿namespace Forum.Domain.Entities;
public class User
{
    public Guid Id { get; set; }

    public required string Name { get; set; }

    public required string Email { get; set; }

    public Guid? AvatarId { get; set; }

    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; }

    public List<Role> Roles { get; set; }

    public const int DescriptionMaxLength = 1000;

    public const int NameMaxLength = 255;

    public const int EmailMaxLength = 255;
}
