using FluentValidation;
using Validation1.Model;

namespace Validation1.Validator;

public class RegistrationValidator : AbstractValidator<CreateUserModel>
{
    public RegistrationValidator()
    {
        RuleFor(u => u.Firstname)
            .NotNull()
            .MaximumLength(16)
            .MinimumLength(3)
            .Must(name => char.IsUpper(name[0]));


        RuleFor(u => u.Lastname)
            .NotNull()
            .MaximumLength(16)
            .MinimumLength(3)
            .Must(name => char.IsUpper(name[0]));


        RuleFor(x => x.Password)
            .NotNull()
            .MinimumLength(8)
            .MaximumLength(32);


        When(u => u.Age is not null, () =>
        {
            RuleFor(u => Convert.ToInt32(u.Age))
                .Must(a => a < 120 && 6 < a);
        });

        When(u => u.Adress is not null, () =>
        {
            RuleFor(u => u.Adress)
                .SetValidator(new AdressValidator()!);
        });
    }
}