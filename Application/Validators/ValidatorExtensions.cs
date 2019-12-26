using FluentValidation;

namespace Application.Validators
{
    public static class ValidatorExtensions
    {
        public static IRuleBuilder<T, string> Password<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            var options = ruleBuilder
                .NotEmpty()
                .MinimumLength(6)
                .WithMessage("Password must contain 6 characters")
                .Matches("[A-Z]").WithMessage("Password must contain upper case")
                .Matches("[a-z]").WithMessage("Password must contain lower case")
                .Matches("[0-9]").WithMessage("Password must contain number")
                .Matches("[^a-zA-Z0.9]").WithMessage("Password must contain non alpha numeric value");

            return options;
        }
    }
}