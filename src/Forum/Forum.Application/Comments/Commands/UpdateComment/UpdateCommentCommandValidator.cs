using FluentValidation;
using Forum.Domain.Entities;

namespace Forum.Application.Comments.Commands.UpdateComment;
public class UpdateCommentCommandValidator : AbstractValidator<UpdateCommentCommand>
{
    public UpdateCommentCommandValidator()
    {
        RuleFor(x => x.CommentId)
            .NotEmpty()
            .WithMessage("Comment id is required");

        RuleFor(x => x.Text)
            .NotEmpty()
            .WithMessage("Text is required")
            .MaximumLength(Comment.CommentMaxLenght)
            .WithMessage($"Comment max lenght {Comment.CommentMaxLenght} is exceeded");
    }
}
