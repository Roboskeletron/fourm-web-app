using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using File = Forum.Domain.Entities.File;

namespace Forum.Domain.Configurations;
public class FileConfiguration : IEntityTypeConfiguration<File>
{
    public void Configure(EntityTypeBuilder<File> builder)
    {
        builder.HasKey(x => x.FileId);

        builder.ToTable($"{nameof(File)}s");
    }
}
