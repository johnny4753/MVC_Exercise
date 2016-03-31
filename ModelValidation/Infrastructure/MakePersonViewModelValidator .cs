using FluentValidation;
using ModelValidation.Models;

namespace ModelValidation.Infrastructure
{
    public class MakePersonViewModelValidator : AbstractValidator<MakePersonViewModel>
    {
        public MakePersonViewModelValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Name).NotNull().Length(3, 5);
            RuleFor(x => x.Email).NotNull().EmailAddress();
            RuleFor(x => x.TermsAccepted).Must(termsAccepted => termsAccepted).WithMessage("Terms should be accepted.");

        }
    }
}