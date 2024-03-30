using BackendCrab.Core.DTOs.CompanyDTOs;
using FluentValidation;

namespace BackendCrab.BusinessLayer.Validation
{
    public class CompanyDTOValidator : AbstractValidator<CompanyDTO>
    {
        public CompanyDTOValidator()
        {
            RuleFor(c => c.Name).NotNull().WithMessage("{PropertyName} is required.").NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(c => c.Address).NotNull().WithMessage("{PropertyName} is required.").NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(c => c.FoundationYear).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater than 0.");
        }
    }
}
