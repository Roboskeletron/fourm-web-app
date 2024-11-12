using FluentValidation;
using Forum.Domain.Entities;

namespace Forum.Application.Users.Commands.UpdateProfile;
public class UpdateProfileCommandValidator : AbstractValidator<UpdateProfileCommand>
{
    public UpdateProfileCommandValidator()
    {
        RuleFor(x => x.Name)
            .MaximumLength(User.NameMaxLength)
            .WithMessage("Name max length exceeded")
            .NotEmpty()
            .WithMessage("Name is required");

        RuleFor(x => x.Description)
            .MaximumLength(User.DescriptionMaxLength)
            .WithMessage("Description max length exceeded");
    }
}
