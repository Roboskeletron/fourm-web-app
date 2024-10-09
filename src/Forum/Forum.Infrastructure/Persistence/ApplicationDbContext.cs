using Forum.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Forum.Domain;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public DbSet<User> Users => Set<User>();

    public DbSet<Topic> Topic => Set<Topic>();

    public DbSet<Message> Message => Set<Message>();

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
