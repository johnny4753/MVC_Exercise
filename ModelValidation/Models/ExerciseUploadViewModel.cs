using System.Web;
using FluentValidation.Attributes;
using ModelValidation.Infrastructure.Exercise;

namespace ModelValidation.Models
{
    [Validator(typeof(ExerciseUploadViewModelValidator))]
    public class ExerciseUploadViewModel
    {
        public HttpPostedFileBase HttpPostedFile { get; set; }
    }
}