using edu.aramco.aspnet.api.Models.Requests;
using edu.aramco.aspnet.domainEntities.Context;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace edu.aramco.aspnet.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
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

        [HttpPut]
        public async Task<IActionResult> Update(UpdateCourseRequestModel request, CancellationToken cancellationToken)
        {
            var course = (CourseRequestModel)request;
            var validationResult = await validator.ValidateAsync(course);
            if (!validationResult.IsValid)
            {
                return UnprocessableEntity(validationResult.ToDictionary());
            }


            var course_tracked = await applicationDbContext.Courses.FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken); var course = await applicationDbContext.Courses.FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken);
            var course_not_tracked = await applicationDbContext.Courses.AsNoTracking().FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken);

            var std = await applicationDbContext.Students.FirstAsync(cancellationToken);

            if (course_tracked is null)
            {
                return NotFound();
            }

            course_tracked.Author = request.Author ?? throw new Exception("Missing author");
            course_tracked.Description = request.Description!;
            course_tracked.Hours = request.Hours;
            course_tracked.Name = request.Name!;
            course_tracked.InstructorId = request.InstructorId;

            //await applicationDbContext.SaveChangesAsync(cancellationToken);

            std.FirstName = "Akmal";
            std.LastName = "Aldahdooh";

            applicationDbContext.Courses.Remove(course_tracked);
            applicationDbContext.Students.Remove(std);

            await applicationDbContext.SaveChangesAsync(cancellationToken);

            return Ok();
            //var validationResult = await validator.ValidateAsync(request);
            //if (!validationResult.IsValid)
            //{
            //    return UnprocessableEntity(validationResult.ToDictionary());
            //}
            //var course = await applicationDbContext.Courses.FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken);
            //if (course is null)
            //{
            //    return NotFound();
            //}
            //course.Author = request.Author;
            //course.Description = request.Description;
            //course.Hours = request.Hours;
            //course.Name = request.Name;
            //course.InstructorId = request.InstructorId;
            //applicationDbContext.Courses.Update(course);
            //await applicationDbContext.SaveChangesAsync(cancellationToken);
            //return NoContent();
        }
    }
}
