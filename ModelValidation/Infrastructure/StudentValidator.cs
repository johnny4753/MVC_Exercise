using FluentValidation;
using ModelValidation.Models;
using ModelValidation.Resources;

namespace ModelValidation.Infrastructure
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(x => x.Id).GreaterThanOrEqualTo(99);

        }
    }
}