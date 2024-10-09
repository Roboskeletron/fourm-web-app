using Forum.Domain.Entities;

namespace Forum.Domain.RBAC;
public static class Roles
{
    public static Role Administrator => new()
    {
        Id = 1,
        Name = "Administrator",
    };

    public static IReadOnlyList<Role> All => new List<Role>
    {
        Administrator,
    };
}

