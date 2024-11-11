using Microsoft.AspNetCore.Mvc;

namespace Forum.Api.Factories;
public interface IProblemDetailsFactory
{
    ProblemDetails CreateProblemDetails<TException>(TException exception) where TException : Exception;
}