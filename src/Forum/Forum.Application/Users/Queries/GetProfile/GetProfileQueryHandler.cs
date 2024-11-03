using AutoMapper;
using Forum.Application.Common.Intrefaces;
using Forum.Application.Common.Models;
using MediatR;

namespace Forum.Application.Users.Queries.GetProfile;
public class GetProfileQueryHandler : IRequestHandler<GetProfileQuery, UserDto>
{
    private readonly IUserProvider _userProvider;
    private readonly IMapper _mapper;

    public GetProfileQueryHandler(IUserProvider userProvider, IMapper mapper)
    {
        _userProvider = userProvider;
        _mapper = mapper;
    }

    public Task<UserDto> Handle(GetProfileQuery request, CancellationToken cancellationToken)
    {
        var user = _userProvider.User;

        return Task.FromResult(_mapper.Map<UserDto>(user));
    }
}
