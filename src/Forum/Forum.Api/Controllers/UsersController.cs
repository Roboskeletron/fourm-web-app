using Forum.Application.Common.Models;
using Forum.Application.Users.Queries.GetProfile;
using Microsoft.AspNetCore.Mvc;

namespace Forum.Api.Controllers;
public class UsersController : ApiControllerBase
{
    [HttpGet("profile")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult<UserDto>> GetProfileAsync(CancellationToken cancellationToken)
    {
        return await Mediator.Send(new GetProfileQuery(), cancellationToken);
    }
}
