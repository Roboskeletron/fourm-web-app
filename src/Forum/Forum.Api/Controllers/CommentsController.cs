using Forum.Application.Comments.Commands.UpdateComment;
using Microsoft.AspNetCore.Mvc;

namespace Forum.Api.Controllers;
public class CommentsController : ApiControllerBase
{
    [HttpPatch("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> UpdateCommentAsync([FromRoute] Guid id, [FromBody] UpdateCommentCommand command, CancellationToken cancellationToken)
    {
        if (id != command.CommentId)
        {
            return BadRequest();
        }

        await Mediator.Send(command, cancellationToken);

        return NoContent();
    }
}
