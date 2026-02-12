using edu.aramco.aspnet.api.Models.Requests;
using edu.aramco.aspnet.domainEntities.Context;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace edu.aramco.aspnet.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoursesController(
        ApplicationDbContext applicationDbContext,
        IValidator<CourseRequestModel> validator
    ) : ControllerBase
    {
        [HttpPost(Name = "Create a new course")]
        public async Task<IActionResult> Add(CourseRequestModel request, CancellationToken cancellationToken)
        {
            var validationResult = await validator.ValidateAsync(request);

            if (!validationResult.IsValid)
            {
                return UnprocessableEntity(validationResult.ToDictionary());
            }

            await applicationDbContext.Courses.AddAsync(new domainEntities.Entities.Course
            {
                Author = request.Author,
                CreatedAt = DateTime.Now,
                Description = request.Description,
                Hours = request.Hours,
                Name = request.Name,
                InstructorId = request.InstructorId
            }, cancellationToken);

            await applicationDbContext.SaveChangesAsync(cancellationToken);
            return NoContent();
        }
    }
}
