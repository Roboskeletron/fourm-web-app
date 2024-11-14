using Forum.Application.Messages.Commands.DeleteMessage;
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
}
