﻿using Forum.Domain.Entities;
using Forum.Infrastructure.Persistence.TestData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forum.Domain.Configurations;
public class MessageConfiguration : IEntityTypeConfiguration<Message>
{
    public void Configure(EntityTypeBuilder<Message> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Text)
            .HasMaxLength(Message.TextMaxLength);

        builder.HasOne(x => x.Author)
            .WithMany()
            .HasForeignKey(x => x.UserId);

        builder.HasMany(x => x.Likes)
            .WithOne()
            .HasForeignKey(x => x.MessageId);

        builder.HasOne<Topic>()
            .WithMany()
            .HasForeignKey(x => x.TopicId);

        builder.HasMany(x => x.Comments)
            .WithOne()
            .HasForeignKey(x => x.MessageId);

        builder.ToTable($"{nameof(Message)}s");

        builder.HasData(Messages.All());
    }
}
