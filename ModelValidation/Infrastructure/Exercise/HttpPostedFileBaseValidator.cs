using System.Web;
using ByteSizeLib;
using FluentValidation;

namespace ModelValidation.Infrastructure.Exercise
{
    public class HttpPostedFileBaseValidator : AbstractValidator<HttpPostedFileBase>
    {
        private const int LimitFileSize = 100;
        public HttpPostedFileBaseValidator()
        {
            RuleFor(x => ByteSize.FromBytes(x.ContentLength).KiloBytes)
                .LessThanOrEqualTo(LimitFileSize)
                .WithMessage("File size must less than {0} KB", LimitFileSize);
        }
    }
}