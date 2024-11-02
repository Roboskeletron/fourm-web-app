using Forum.Application.Common.Intrefaces;
using System.Security.Claims;

namespace Forum.Api.Middlewares
{
    public class UserProviderInitiatorMiddleware : IMiddleware
    {
        private readonly IUserProviderBuilder _userProviderBuilder;

        public UserProviderInitiatorMiddleware(IUserProviderBuilder userProviderBuilder)
        {
            _userProviderBuilder = userProviderBuilder;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var claimsIdentity = context.User.Identity as ClaimsIdentity;

            if (claimsIdentity == null || !claimsIdentity.IsAuthenticated)
            {
                await next(context);
                return;
            }

            await _userProviderBuilder.FromClaimsIdentity(claimsIdentity);

            await next(context);
        }
    }
}
