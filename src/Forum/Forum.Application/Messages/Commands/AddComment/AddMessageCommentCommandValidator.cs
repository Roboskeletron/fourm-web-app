using FluentValidation;
using Forum.Domain.Entities;

namespace Forum.Application.Messages.Commands.AddComment;
public class AddMessageCommentCommandValidator : AbstractValidator<AddMessageCommentCommand>
{
    public AddMessageCommentCommandValidator()
    {
        RuleFor(x => x.MessageId)
            .NotEmpty()
            .WithMessage("Message id is required");

        RuleFor(x => x.Comment)
            .NotEmpty()
            .WithMessage("Comment is required")
            .MaximumLength(Comment.CommentMaxLenght)
            .WithMessage($"Comment max lenght {Comment.CommentMaxLenght} is exceeded");
    }
}
