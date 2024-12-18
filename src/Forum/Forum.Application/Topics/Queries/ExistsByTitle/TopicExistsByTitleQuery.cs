using MediatR;

namespace Forum.Application.Topics.Queries.ExistsByTitle;

public record TopicExistsByTitleQuery : IRequest<bool>
{
    public required string Title { get; init; }
}
