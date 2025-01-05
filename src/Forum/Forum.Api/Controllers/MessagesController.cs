using Forum.Application.Messages.Commands.DeleteMessage;
using Forum.Application.Messages.Commands.UpdateMessage;
using Microsoft.AspNetCore.Mvc;

namespace Forum.Api.Controllers;
public class MessagesController : ApiControllerBase
{
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> DeleteMessageAsync([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        await Mediator.Send(new DeleteMessageCommand { MessageId = id }, cancellationToken);
        return NoContent();
    }

    [HttpPatch("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> UpdateMessageAsync([FromRoute] Guid id, [FromBody] UpdateMessageCommand command, CancellationToken cancellationToken)
    {
        if (id != command.MessageId)
        {
            return BadRequest();
        }

        await Mediator.Send(command, cancellationToken);

        return NoContent();
    }
}
