using FluentValidation;
using Forum.Domain.Entities;

namespace Forum.Application.Comments.Commands.CreateComment;
public class CreateMessageCommentCommandValidator : AbstractValidator<CreateMessageCommentCommand>
{
    public CreateMessageCommentCommandValidator()
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
