using FluentValidation;
using Forum.Domain.Entities;

namespace Forum.Application.Messages.Commands.CreateMessage;
public class CreateMessageCommandValidator : AbstractValidator<CreateMessageCommand>
{
    public CreateMessageCommandValidator()
    {
        RuleFor(x => x.Text)
            .NotEmpty()
            .WithMessage("Text is required")
            .MaximumLength(Message.TextMaxLength)
            .WithMessage("Text max length exceeded");
    }
}
