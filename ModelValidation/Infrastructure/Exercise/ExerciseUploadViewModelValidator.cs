using FluentValidation;
using ModelValidation.Models;

namespace ModelValidation.Infrastructure.Exercise
{
    public class ExerciseUploadViewModelValidator :AbstractValidator<ExerciseUploadViewModel>
    {
        public ExerciseUploadViewModelValidator()
        {
            RuleFor(x => x.HttpPostedFile).NotNull().WithMessage("請選擇檔案");
            RuleFor(x => x.HttpPostedFile).SetValidator(new HttpPostedFileBaseValidator());
        }
    }
}