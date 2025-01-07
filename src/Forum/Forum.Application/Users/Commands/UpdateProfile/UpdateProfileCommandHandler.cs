using AutoMapper;
using Forum.Application.Common.Intrefaces;
using Forum.Domain;
using Forum.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

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
        var user = await _dbContext.Users
            .Include(x => x.Avatar)
            .FirstOrDefaultAsync(x => x.Id == _userProvider.User!.Id, cancellationToken);

        _mapper.Map(request, user!);

        if (request.Avatar != null)
        {
            using var stream = new MemoryStream();
            await request.Avatar.CopyToAsync(stream, cancellationToken);

            var avatar = new Avatar
            {
                Data = stream.ToArray(),
            };

            user!.Avatar = avatar;
        }

        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
