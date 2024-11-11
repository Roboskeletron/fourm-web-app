using AutoMapper;
using Forum.Application.Common.Intrefaces;
using Forum.Domain;
using MediatR;

namespace Forum.Application.Users.Commands.UpdateProfile;
public class UpdateProfileCommandHandler : IRequestHandler<UpdateProfileCommand>
{
    private readonly IApplicationDbContext _dbContext;
    private readonly IUserProvider _userProvider;
    private readonly IMapper _mapper;

    public UpdateProfileCommandHandler(
        IApplicationDbContext dbContext,
        IUserProvider userProvider,
        IMapper mapper)
    {
        _dbContext = dbContext;
        _userProvider = userProvider;
        _mapper = mapper;
    }

    public async Task Handle(UpdateProfileCommand request, CancellationToken cancellationToken)
    {
        var user = _userProvider.User;

        _mapper.Map(request, user);

        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
