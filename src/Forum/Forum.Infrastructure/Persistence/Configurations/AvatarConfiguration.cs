using Forum.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forum.Infrastructure.Persistence.Configurations;
public class AvatarConfiguration : IEntityTypeConfiguration<Avatar>
{
    public void Configure(EntityTypeBuilder<Avatar> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne<User>()
            .WithOne(x => x.Avatar)
            .HasForeignKey<Avatar>(x => x.UserId);

        builder.ToTable($"{nameof(Avatar)}s");
    }
}
