using FluentValidation;
using FluentValidation.Results;
using MediatR;

namespace Forum.Application.Behaviors;
public class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : notnull
{
    private readonly IEnumerable<IValidator<TRequest>> _validators;

    public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        var validationTasks = _validators.Select(v => v.ValidateAsync(request, cancellationToken));
        var validationResults = await Task.WhenAll(validationTasks);

        ThrowIfValidationFailed(validationResults);

        return await next();
    }

    private static void ThrowIfValidationFailed(IEnumerable<ValidationResult> validationResults)
    {
        var validationErrors = validationResults
            .Where(r => !r.IsValid)
            .SelectMany(r => r.Errors)
            .ToList();

        if (validationErrors.Count == 0)
        {
            return;
        }

        throw new ValidationException(validationErrors);
    }
}
