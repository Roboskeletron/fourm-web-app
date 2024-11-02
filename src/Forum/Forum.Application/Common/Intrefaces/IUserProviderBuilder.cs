using Forum.Domain.Entities;
using System.Security.Claims;

namespace Forum.Application.Common.Intrefaces;
public interface IUserProviderBuilder
{
    IUserProvider Build();

    Task<IUserProviderBuilder> FromClaimsIdentity(ClaimsIdentity identity);
}
