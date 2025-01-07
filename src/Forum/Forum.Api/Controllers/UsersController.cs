using Forum.Application.Common.Models;
using Forum.Application.Users.Commands.Register;
using Forum.Application.Users.Commands.UpdateProfile;
using Forum.Application.Users.Queries.ExistsByEmail;
using Forum.Application.Users.Queries.ExistsByUsername;
using Forum.Application.Users.Queries.GetAvatar;
using Forum.Application.Users.Queries.GetProfile;
using Forum.Application.Users.Queries.GetUserById;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

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
    public async Task<ActionResult> UpdateProfileAsync([FromForm] UpdateProfileCommand command, CancellationToken cancellationToken)
    {
        await Mediator.Send(command, cancellationToken);
        return Ok();
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType]
    [AllowAnonymous]
    public async Task<ActionResult> RegisterUserAsync([FromBody] RegisterUserCommand command, CancellationToken cancellationToken)
    {
        await Mediator.Send(command, cancellationToken);
        return Created();
    }

    [HttpGet("exists-by-email")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesDefaultResponseType]
    [AllowAnonymous]
    public async Task<ActionResult<bool>> ExistsByEmailAsync([FromQuery] string email, CancellationToken cancellationToken)
    {
        return await Mediator.Send(new UserExistsByEmailQuery { Email = email }, cancellationToken);
    }

    [HttpGet("exists-by-username")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesDefaultResponseType]
    [AllowAnonymous]
    public async Task<ActionResult<bool>> ExistsByUsernameAsync([FromQuery] string username, CancellationToken cancellationToken)
    {
        return await Mediator.Send(new UserExistsByUsernameQuery { Username = username }, cancellationToken);
    }

    [HttpGet("{id}/avatar")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    [AllowAnonymous]
    public async Task<ActionResult> GetUserAvatarAsync([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var avatar = await Mediator.Send(new GetUserAvatarQuery { UserId = id }, cancellationToken);

        if (avatar == null)
        {
            return NoContent();
        }

        return File(avatar.Data, MediaTypeNames.Image.Bmp);
    }
}
