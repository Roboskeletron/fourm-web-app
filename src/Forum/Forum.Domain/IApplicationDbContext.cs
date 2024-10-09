using Forum.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Forum.Domain;
public interface IApplicationDbContext
{
    public DbSet<User> Users { get; }

    public DbSet<Topic> Topic { get; }

    public DbSet<Message> Message { get; }
}

