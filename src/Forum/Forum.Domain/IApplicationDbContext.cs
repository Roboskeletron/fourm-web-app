using Forum.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Forum.Domain;
public interface IApplicationDbContext
{
    DbSet<User> Users { get; }

    DbSet<Topic> Topic { get; }

    DbSet<Message> Message { get; }

    DbSet<Comment> Comment { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}

