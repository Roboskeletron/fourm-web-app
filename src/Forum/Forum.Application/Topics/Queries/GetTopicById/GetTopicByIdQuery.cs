using Forum.Application.Common.Models;
using MediatR;

namespace Forum.Application.Topics.Queries.GetTopicById;
public class GetTopicByIdQuery : IRequest<TopicDto>
{
    public Guid TopicId { get; init; }
}
