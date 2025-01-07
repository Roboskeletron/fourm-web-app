using Forum.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forum.Domain.Configurations;
public class MessageLikeConfiguration : IEntityTypeConfiguration<MessageLike>
{
    public void Configure(EntityTypeBuilder<MessageLike> builder)
    {
        builder.HasKey(x => x.Id);

        builder.ToTable($"{nameof(MessageLike)}s");
    }
}
