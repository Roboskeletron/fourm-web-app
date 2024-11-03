using Forum.Application.Common.Models;
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
}
