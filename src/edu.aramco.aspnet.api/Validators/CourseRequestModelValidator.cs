using edu.aramco.aspnet.api.Models.Requests;
using FluentValidation;

namespace edu.aramco.aspnet.api.Validators
{
    public class CourseRequestModelValidator : AbstractValidator<CourseRequestModel>
    {
        public CourseRequestModelValidator()
        {
            RuleFor(x => x.Hours).InclusiveBetween(1, 4).WithMessage("Hours should be between 1 and 4");

            RuleFor(x => x.Author).NotNull().WithMessage("Author should not be null");
            RuleFor(x => x.Author).NotEmpty().WithMessage("Author should not be empty string");

            RuleFor(x => x.InstructorId).NotNull();
            RuleFor(x => x.Name).NotNull().WithMessage("NOT NULL").NotEmpty().WithMessage("NOT EMPTY");
            RuleFor(x => x.Description).NotNull().NotEmpty().MaximumLength(200);
        }
    }
}
