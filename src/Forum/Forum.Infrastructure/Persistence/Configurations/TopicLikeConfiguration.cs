using Forum.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forum.Domain.Configurations;
public class TopicLikeConfiguration : IEntityTypeConfiguration<TopicLike>
{
    public void Configure(EntityTypeBuilder<TopicLike> builder)
    {
        builder.HasKey(x => x.Id);

        builder.ToTable($"{nameof(TopicLike)}s");
    }
}
