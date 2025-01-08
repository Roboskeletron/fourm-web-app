using Forum.Domain.Entities;
using Forum.Infrastructure.Persistence.TestData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forum.Domain.Configurations;
public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasIndex(x => x.Email)
            .IsUnique();

        builder.Property(x => x.Description)
            .HasMaxLength(User.DescriptionMaxLength);

        builder.Property(x => x.Name)
            .HasMaxLength(User.NameMaxLength);

        builder.Property(x => x.Email)
            .HasMaxLength(User.EmailMaxLength);

        builder.HasMany<MessageLike>()
            .WithOne()
            .HasForeignKey(x => x.UserId);

        builder.HasMany<TopicLike>()
            .WithOne()
            .HasForeignKey(x => x.UserId);

        builder.HasMany<Comment>()
            .WithOne(x => x.Author)
            .HasForeignKey(x => x.AuthorId);

        builder.ToTable($"{nameof(User)}s");

        builder.HasData(Users.All);
    }
}
