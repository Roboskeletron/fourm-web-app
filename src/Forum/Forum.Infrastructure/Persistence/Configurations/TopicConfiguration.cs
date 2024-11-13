using Forum.Domain.Entities;
using Forum.Infrastructure.Persistence.TestData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forum.Domain.Configurations;
public class TopicConfiguration : IEntityTypeConfiguration<Topic>
{
    public void Configure(EntityTypeBuilder<Topic> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasIndex(x => x.Title);

        builder.Property(x => x.Title)
            .HasMaxLength(Topic.TitleMaxLength);

        builder.Property(x => x.Description)
            .HasMaxLength(Topic.DescriptionMaxLength);

        builder.HasOne(x => x.Author)
            .WithMany()
            .HasForeignKey(x => x.UserId);

        builder.ToTable($"{nameof(Topic)}s");

        builder.HasData(Topics.All);
    }
}
