using Forum.Api.Factories;
using Microsoft.AspNetCore.Diagnostics;

namespace Forum.Api.ExceptionHandlers;
public class GlobalExceptionHandler : IExceptionHandler
{
    private readonly IProblemDetailsFactory _problemDetailsFactory;

    public GlobalExceptionHandler(IProblemDetailsFactory problemDetailsFactory)
    {
        _problemDetailsFactory = problemDetailsFactory;
    }

    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
    {
        var problemDetails = _problemDetailsFactory.CreateProblemDetails(exception);

        problemDetails.Extensions["traceId"] = httpContext.TraceIdentifier;

        httpContext.Response.StatusCode = problemDetails.Status ?? StatusCodes.Status500InternalServerError;
        await httpContext.Response.WriteAsJsonAsync(problemDetails, cancellationToken);

        return true;
    }
}
