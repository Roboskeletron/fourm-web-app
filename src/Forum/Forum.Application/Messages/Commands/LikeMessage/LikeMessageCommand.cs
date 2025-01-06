using Forum.Application.Common.Models;
using MediatR;

namespace Forum.Application.Messages.Commands.LikeMessage;
public record LikeMessageCommand : IRequest<MessageDto>
{
    public Guid MessageId { get; init; }
}
