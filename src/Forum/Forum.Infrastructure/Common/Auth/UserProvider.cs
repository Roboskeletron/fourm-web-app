using Forum.Application.Common.Intrefaces;
using Forum.Domain.Entities;
namespace Forum.Infrastructure.Common.Auth;
internal class UserProvider : IUserProvider
{
    public User? User { get; private set; }

    public UserProvider(User? user)
    {
        User = user;
    }
}

