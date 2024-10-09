using Forum.Domain.Entities;

namespace Forum.Infrastructure.Persistence.TestData;
internal static class Users
{
    public static User TestUser => new()
    {
        Id = new Guid("00000000-0000-0000-0000-000000000001"),
        Name = "Test user",
        Email = "test.user@mail.com",
        CreatedAt = DateTime.UtcNow,
    };

    public static IReadOnlyList<User> All => new List<User>
    {
        TestUser
    };
}
