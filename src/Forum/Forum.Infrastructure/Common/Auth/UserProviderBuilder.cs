using Forum.Application.Common.Intrefaces;
using Forum.Domain;
using Forum.Domain.Entities;
using Forum.Infrastructure.Common.Auth;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Forum.Infrastructure.Common.Builders;
internal class UserProviderBuilder : IUserProviderBuilder
{
    private readonly IApplicationDbContext _dbContext;

    private User? _user;

    public UserProviderBuilder(IApplicationDbContext applicationDbContext)
    {
        _dbContext = applicationDbContext;
    }

    public IUserProvider Build() => new UserProvider(_user);

    public async Task<IUserProviderBuilder> FromClaimsIdentity(ClaimsIdentity identity)
    {
        var userIdClaim = identity.FindFirst(ClaimTypes.UserId)
            ?? throw new InvalidOperationException($"Claim {ClaimTypes.UserId} is not provided");

        var userNameClaim = identity.FindFirst(ClaimTypes.UserName)
            ?? throw new InvalidOperationException($"Claim {ClaimTypes.UserName} is not provided");

        var emailClaim = identity.FindFirst(ClaimTypes.Email)
            ?? throw new InvalidOperationException($"Claim {ClaimTypes.Email} is not provided");

        var userId = Guid.Parse(userIdClaim.Value);

        _user = await GetOrCreateUserAsync(userId, userNameClaim.Value, emailClaim.Value);

        return this;
    }

    private async Task<User> GetOrCreateUserAsync(Guid userId, string userName, string email)
    {
        var user = await _dbContext.Users
            .Include(x => x.Roles)
            .FirstOrDefaultAsync(x => x.Id == userId);

        if (user == null)
        {
            user = new User
            {
                Id = userId,
                Name = userName,
                Email = email,
                CreatedAt = DateTime.UtcNow,
            };

            _dbContext.Users.Add(user);

            await _dbContext.SaveChangesAsync();
        }

        return user;
    }

    public static class ClaimTypes
    {
        public const string UserId = "sub";
        public const string UserName = "preferred_username";
        public const string Email = "email";
    }
}
