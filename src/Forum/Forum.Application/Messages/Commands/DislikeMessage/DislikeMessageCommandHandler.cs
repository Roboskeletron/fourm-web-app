using AutoMapper;
using Forum.Application.Common.Exceptions;
using Forum.Application.Common.Intrefaces;
using Forum.Application.Common.Models;
using Forum.Domain;
using Forum.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Forum.Application.Messages.Commands.DislikeMessage;
public class DislikeMessageCommandHandler : IRequestHandler<DislikeMessageCommand, MessageDto>
{
    private readonly IApplicationDbContext _dbContext;
    private readonly IUserProvider _userProvider;
    private readonly IMapper _mapper;

    public DislikeMessageCommandHandler(IApplicationDbContext dbContext, IUserProvider userProvider, IMapper mapper)
    {
        _dbContext = dbContext;
        _userProvider = userProvider;
        _mapper = mapper;
    }

    public async Task<MessageDto> Handle(DislikeMessageCommand command, CancellationToken cancellationToken)
    {
        var message = await _dbContext.Message
        .Include(x => x.Likes)
        .Include(x => x.Author)
            .FirstOrDefaultAsync(x => x.Id == command.MessageId && !x.IsDeleted, cancellationToken)
            ?? throw new NotFoundException(nameof(Message), command.MessageId);

        var like = message.Likes.FirstOrDefault(x => x.UserId == _userProvider.User!.Id)
            ?? throw new InvalidOperationException($"Message {message.Id} is not liked by user {_userProvider.User!.Id}");

        message.Likes.Remove(like);

        await _dbContext.SaveChangesAsync(cancellationToken);

        return new MessageDto
        {
            Id = message.Id,
            Author = _mapper.Map<AuthorDto>(message.Author),
            CreatedAt = message.CreatedAt,
            UpdatedAt = message.UpdatedAt,
            CanLike = true,
            Text = message.Text,
            TopicId = message.TopicId,
            LikeCount = message.Likes.Count,
        };
    }
}
