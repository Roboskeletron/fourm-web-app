using FluentValidation;
using Forum.Domain.Entities;

namespace Forum.Application.Topics.Commands.CreateTopic;
public class CreateTopicCommandValidator : AbstractValidator<CreateTopicCommand>
{
    public CreateTopicCommandValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty()
            .WithMessage("Title is required")
            .MaximumLength(Topic.TitleMaxLength)
            .WithMessage($"Title max length {Topic.TitleMaxLength} exceeded");

        RuleFor(x => x.Description)
            .MaximumLength(Topic.DescriptionMaxLength)
            .WithMessage($"Description max length {Topic.DescriptionMaxLength} exceeded");
    }
}
