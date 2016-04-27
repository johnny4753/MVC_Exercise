using FluentValidation;
using ModelValidation.Models;

namespace ModelValidation.Infrastructure
{
    public class TesterValidator : AbstractValidator<Tester>
    {
        public TesterValidator()
        {
            RuleFor(x => x.TestId).LessThanOrEqualTo(10);
        }
    }
}