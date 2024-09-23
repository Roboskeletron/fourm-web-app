using Forum.Domain.Entities;
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

        builder.HasMany<User>()
            .WithMany()
            .UsingEntity<MessageLike>();

        builder.HasMany(x => x.Files)
            .WithOne()
            .HasForeignKey(x => x.MessageId);

        builder.ToTable($"{nameof(Message)}s");
    }
}
