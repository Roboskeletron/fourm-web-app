using Forum.Application.Common.Models;
using Forum.Application.Topics.Commands.CreateTopic;
using Forum.Application.Topics.Queries.GetTopicMessages;
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
        return await Mediator.Send(new GetTopicMessagesQuery
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
        return CreatedAtAction(null, topicId);
    }
}
