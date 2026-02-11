using edu.aramco.aspnet.domainEntities.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace edu.aramco.aspnet.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoursesController(
        ApplicationDbContext applicationDbContext
    ) : ControllerBase
    {
        [HttpPost(Name = "Create a new course")]
        public async Task<IActionResult> Add(CancellationToken cancellationToken)
        {
            await applicationDbContext.Courses.AddAsync(new domainEntities.Entities.Course
            {
                Author = "Author",
                CreatedAt = DateTime.Now,
                Description = "Description",
                Hours = 3,
                Name = "COurse 1",
                InstructorId = Guid.Parse("47889dc6-4070-42db-b2d3-08de689ef6e3")
            }, cancellationToken);

            await applicationDbContext.SaveChangesAsync(cancellationToken);
            return NoContent();
        }
    }
}
