using edu.aramco.aspnet.domainEntities.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace edu.aramco.aspnet.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnrollmentsController(
        ApplicationDbContext applicationDbContext
    ) : ControllerBase
    {
        [HttpGet(Name = "Get All Enrollments")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var enrollments = await applicationDbContext.Enrollments
                .Include(e => e.Course)
                .Include(e => e.Student)
                .Select(x=> new
                {
                    Course = new
                    {
                        x.Course.Id,
                        x.Course.Name
                    },
                    Student = new
                    {
                        x.Student.Id,
                        x.Student.FirstName,
                        x.Student.LastName
                    },
                    x.EnrollmentDate
                })
                .ToListAsync(cancellationToken);
            return Ok(enrollments);
        }


        [HttpPost(Name = "Create a new enrollment")]
        public async Task<IActionResult> Add(CancellationToken cancellationToken)
        {
            await applicationDbContext.Enrollments.AddAsync(new domainEntities.Entities.Enrollment
            {
                CourseId = 1,
                StudentId = Guid.Parse("47889dc6-4070-42db-b2d3-08de689ef6e3"),
                EnrollmentDate = DateTime.Now,
            }, cancellationToken);

            await applicationDbContext.SaveChangesAsync(cancellationToken);
            return NoContent();
        }
    }
}
