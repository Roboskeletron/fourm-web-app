using FluentValidation;
using Forum.Application.Common.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace Forum.Api.Factories;
public class ProblemDetailsFactory : IProblemDetailsFactory
{
    public ProblemDetails CreateProblemDetails<TException>(TException exception)
        where TException : Exception => exception switch
        {

            NotFoundException notFoundException => new ProblemDetails
            {
                Status = StatusCodes.Status404NotFound,
                Title = "Not Found",
                Type = "https://tools.ietf.org/doc/html/rfc7231#section-6.5.4"
            },
            ForbiddenAccessException forbiddenAccessException => new ProblemDetails
            {
                Status = StatusCodes.Status403Forbidden,
                Title = "Forbidden",
                Type = "https://tools.ietf.org/doc/html/rfc7231#section-6.5.3"
            },
            ValidationException validationException => new ProblemDetails
            {
                Status = StatusCodes.Status400BadRequest,
                Title = "Bad Request",
                Type = "https://tools.ietf.org/html/rfc7231#section-6.5.1",
                Detail = "One or more validation errors occured",
                Extensions =
            {
                ["ErrorCodes"] = validationException.Errors
                    .Select(e => e.ErrorCode)
            }
            },
            _ => new ProblemDetails
            {
                Status = StatusCodes.Status500InternalServerError,
                Title = "Internal Server Error",
                Type = "https://tools.ietf.org/html/rfc7231#section-6.6.1"
            }
        };
}
