using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Forum.Api.Controllers;

[ApiController]
[Authorize]
[Route("api/[controller]")]
public class ApiControllerBase : ControllerBase
{
    protected IMediator? _mediator;

    public IMediator Mediator => _mediator ?? HttpContext.RequestServices.GetRequiredService<IMediator>();
}
