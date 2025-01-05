using FluentValidation;
using Forum.Domain.Entities;

namespace Forum.Application.Messages.Commands.UpdateMessage;
public class UpdateMessageCommandValidator : AbstractValidator<UpdateMessageCommand>
{
    public UpdateMessageCommandValidator()
    {
        RuleFor(x => x.MessageId)
            .NotEmpty()
            .WithMessage("Message id is required");

        RuleFor(x => x.Text)
            .NotEmpty()
            .WithMessage("Text is required")
            .MaximumLength(Message.TextMaxLength)
            .WithMessage("Text max length exceeded");
    }
}
