using Forum.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forum.Domain.Configurations;
public class MessageFileConfiguration : IEntityTypeConfiguration<MessageFile>
{
    public void Configure(EntityTypeBuilder<MessageFile> builder)
    {
        builder.HasKey(x => x.FileId);

        builder.ToTable($"{nameof(MessageFile)}s");
    }
}
