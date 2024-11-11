using Forum.Application.Common.Models;
using Forum.Application.Users.Commands.UpdateProfile;
using Forum.Application.Users.Queries.GetProfile;
using Forum.Application.Users.Queries.GetUserById;
using Microsoft.AspNetCore.Authorization;
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

    [HttpGet("profile/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    [AllowAnonymous]
    public async Task<ActionResult<UserDto>> GetUserProfileByIdAsync([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        return await Mediator.Send(new GetUserByIdQuery { UserId = id }, cancellationToken);
    }

    [HttpPut("profile")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> UpdateProfileAsync([FromBody] UpdateProfileCommand command, CancellationToken cancellationToken)
    {
        await Mediator.Send(command, cancellationToken);
        return Ok();
    }
}
