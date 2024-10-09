using Forum.Domain.Entities;

namespace Forum.Infrastructure.Persistence.TestData;
internal static class Topics
{
    public static Topic TestTopic1 => new()
    {
        Id = new Guid("00000000-0000-0000-0000-000000000001"),
        Title = "Test topic 1",
        UserId = Users.TestUser.Id,
    };

    public static Topic TestTopic2 => new()
    {
        Id = new Guid("00000000-0000-0000-0000-000000000002"),
        Title = "Test topic 2",
        UserId = Users.TestUser.Id,
    };

    public static IReadOnlyList<Topic> All => new List<Topic>
    {
        TestTopic1,
        TestTopic2,
    };
}
