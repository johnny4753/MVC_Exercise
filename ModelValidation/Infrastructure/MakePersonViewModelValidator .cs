using FluentValidation;
using ModelValidation.Models;
using ModelValidation.Resources;

namespace ModelValidation.Infrastructure
{
    public class MakePersonViewModelValidator : AbstractValidator<MakePersonViewModel>
    {
        public MakePersonViewModelValidator()
        {
            RuleFor(x => x.Id).NotNull().Must((makePersonViewModel,id)=>id <= makePersonViewModel.Limit.LimitId);
            RuleFor(x => x.Name).NotNull().Length(3, 5);
            RuleFor(x => x.Email).NotNull().EmailAddress().WithLocalizedMessage(()=>Resource.EmailErrorMessage);
            RuleFor(x => x.TermsAccepted).Must(termsAccepted => termsAccepted).WithMessage("Terms should be accepted.");
            
        }
    }
}