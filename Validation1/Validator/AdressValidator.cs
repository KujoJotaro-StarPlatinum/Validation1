using FluentValidation;
using Validation1.Model;

namespace Validation1.Validator;

public class AdressValidator : AbstractValidator<Adress>
{
    public AdressValidator()
    {
        RuleFor(adress => adress.City)
            .NotNull()
            .WithMessage("City cannot be empty");


        RuleFor(a => a.Country)
            .NotNull()
            .Must(c => c == "Uzbekistan");


        RuleFor(a => a.ZipCode)
            .LessThan(110000)
            .GreaterThan(100000);
    }
}