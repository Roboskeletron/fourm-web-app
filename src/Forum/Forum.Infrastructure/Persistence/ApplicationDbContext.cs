using Forum.Domain;
using Forum.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Forum.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public DbSet<User> Users => Set<User>();

    public DbSet<Topic> Topic => Set<Topic>();

    public DbSet<Message> Message => Set<Message>();

    public DbSet<Comment> Comment => Set<Comment>();

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    Task<int> IApplicationDbContext.SaveChangesAsync(CancellationToken cancellationToken) => base.SaveChangesAsync(cancellationToken);
}
