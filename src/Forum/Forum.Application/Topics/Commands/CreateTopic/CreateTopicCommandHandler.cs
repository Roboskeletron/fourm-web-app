using AutoMapper;
using Forum.Application.Common.Intrefaces;
using Forum.Domain;
using Forum.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Forum.Application.Topics.Commands.CreateTopic;
public class CreateTopicCommandHandler : IRequestHandler<CreateTopicCommand, Guid>
{
    private readonly IApplicationDbContext _dbContext;
    private readonly IUserProvider _userProvider;
    private readonly IMapper _mapper;

    public CreateTopicCommandHandler(
        IApplicationDbContext dbContext,
        IUserProvider userProvider,
        IMapper mapper)
    {
        _dbContext = dbContext;
        _userProvider = userProvider;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(CreateTopicCommand request, CancellationToken cancellationToken)
    {
        var topic = _mapper.Map<Topic>(request);

        topic.Author = _userProvider.User!;

        var isTitleExist = await _dbContext.Topic.AnyAsync(x => x.Title == request.Title && !x.IsDeleted, cancellationToken);

        if (isTitleExist)
        {
            throw new ArgumentException();
        }

        _dbContext.Topic.Add(topic);
        await _dbContext.SaveChangesAsync(cancellationToken);

        return topic.Id;
    }
}
