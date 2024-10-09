using Forum.Domain.Entities;

namespace Forum.Infrastructure.Persistence.TestData;

internal static class Messages
{
    public static IEnumerable<Message> All()
    {
        for (int i = 1; i <= 1000; i++)
        {
            var messageGuid = new Guid(i, 0, 0, new byte[] { 0, 0, 0, 0, 0, 0, 0, 1 });

            yield return new Message
            {
                Id = messageGuid,
                Text = $"This is message {i}",
                UserId = Users.TestUser.Id,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                IsDeleted = false,
                TopicId = (i % 2 == 0) ? Topics.TestTopic1.Id : Topics.TestTopic2.Id
            };
        }
    }
}
