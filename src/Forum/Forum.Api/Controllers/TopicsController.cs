using Microsoft.AspNetCore.Mvc;

namespace Forum.Api.Controllers;

public class TopicsController : ApiControllerBase
{
    [HttpGet("echo")]
    public Task<int> Echo(int number, CancellationToken cancellationToken)
    {
        return Task.FromResult(number);
    }
}
