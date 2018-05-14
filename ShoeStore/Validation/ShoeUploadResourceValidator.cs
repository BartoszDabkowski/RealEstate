using FluentValidation;
using ShoeStore.Controllers.Resources;

namespace ShoeStore.Validation
{
    public class ShoeUploadResourceValidator : AbstractValidator<SaveShoeResource>
    {
        public ShoeUploadResourceValidator () {
            RuleFor(x => x.Styles)
                .Must(x => x.Count > 0)
                .WithMessage("At lease one style is required");

            RuleFor(x => x.Colors)
                .Must(x => x.Count > 0)
                .WithMessage("At lease one color is required");
        }
    }
}