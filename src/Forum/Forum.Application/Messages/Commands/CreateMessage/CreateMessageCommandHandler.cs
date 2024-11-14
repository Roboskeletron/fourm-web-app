using AutoMapper;
using Forum.Application.Common.Exceptions;
using Forum.Application.Common.Intrefaces;
using Forum.Domain;
using Forum.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Application.Messages.Commands.CreateMessage;
public class CreateMessageCommandHandler : IRequestHandler<CreateMessageCommand, Guid>
{
    private readonly IApplicationDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly IUserProvider _userProvider;

    public CreateMessageCommandHandler(IApplicationDbContext dbContext, IMapper mapper, IUserProvider userProvider)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _userProvider = userProvider;
    }

    public async Task<Guid> Handle(CreateMessageCommand request, CancellationToken cancellationToken)
    {
        var topic = await _dbContext.Topic.FirstOrDefaultAsync(x => x.Id ==  request.TopicId, cancellationToken)
            ?? throw new NotFoundException(nameof(Topic), request.TopicId);

        var message = _mapper.Map<Message>(request);

        message.Author = _userProvider.User!;
        message.CreatedAt = DateTime.UtcNow;
        
        _dbContext.Message.Add(message);

        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
