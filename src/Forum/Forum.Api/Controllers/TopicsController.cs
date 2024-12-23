using Forum.Application.Common.Models;
using Forum.Application.Messages.Commands.CreateMessage;
using Forum.Application.Messages.Queries.GetTopicMessages;
using Forum.Application.Topics.Commands.CreateTopic;
using Forum.Application.Topics.Commands.UpdateTopic;
using Forum.Application.Topics.Queries.ExistsByTitle;
using Forum.Application.Topics.Queries.GetTopicById;
using Forum.Application.Topics.Queries.GetTopics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Forum.Api.Controllers;

public class TopicsController : ApiControllerBase
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesDefaultResponseType]
    [AllowAnonymous]
    public async Task<ActionResult<PagedList<TopicDto>>> GetTopicsAsync(
        [FromQuery(Name = "search")] string? searchQuery,
        [FromQuery] PaginationParameters pagination,
        CancellationToken cancellationToken)
    {
        return await Mediator.Send(new GetTopicsQuery
        {
            Pagination = pagination,
            SearchQuery = searchQuery,
        }, cancellationToken);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    [AllowAnonymous]
    public async Task<ActionResult<TopicDto>> GetTopicByIdAsync([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        return await Mediator.Send(new GetTopicByIdQuery { TopicId = id }, cancellationToken);
    }

    [HttpGet("{id}/messages")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesDefaultResponseType]
    [AllowAnonymous]
    public async Task<ActionResult<PagedList<MessageDto>>> GetTopicMessagesAsync(
        [FromRoute] Guid id,
        [FromQuery(Name = "search")] string? searchQuery,
        [FromQuery] PaginationParameters pagination,
        CancellationToken cancellationToken)
    {
        return await Mediator.Send(new GetMessagesByTopicIdQuery
        {
            TopicId = id,
            Pagination = pagination,
            SearchQuery = searchQuery,
        }, cancellationToken);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult<Guid>> CreateTopicAsync([FromBody] CreateTopicCommand command, CancellationToken cancellationToken)
    {
        var topicId = await Mediator.Send(command, cancellationToken);
        return CreatedAtAction(nameof(GetTopicByIdAsync), topicId);
    }

    [HttpPost("{id}/messages")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult<Guid>> SendMessageAsync(
        [FromRoute] Guid id,
        [FromBody] CreateMessageCommand command,
        CancellationToken cancellationToken)
    {
        if (id != command.TopicId)
        {
            return BadRequest();
        }

        var topicId = await Mediator.Send(command, cancellationToken);

        return CreatedAtAction(null, topicId);
    }

    [HttpGet("exists-by-title")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesDefaultResponseType]
    [AllowAnonymous]
    public async Task<ActionResult<bool>> TopicExistsByTitleAsync([FromQuery] string title, CancellationToken cancellationToken)
    {
        return await Mediator.Send(new TopicExistsByTitleQuery { Title = title }, cancellationToken);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> UpdateTopicAsync([FromRoute] Guid id, [FromBody] UpdateTopicCommand command, CancellationToken cancellationToken)
    {
        if (id != command.TopicId)
        {
            return BadRequest();
        }

        await Mediator.Send(command, cancellationToken);

        return NoContent();
    }
}
