using Forum.Application.Common.Models;
using MediatR;

namespace Forum.Application.Messages.Commands.DislikeMessage;
public record DislikeMessageCommand : IRequest<MessageDto>
{
    public Guid MessageId { get; init; }
}
