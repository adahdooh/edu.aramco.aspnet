using edu.aramco.aspnet.domainEntities.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace edu.aramco.aspnet.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InstructorsController(
        ApplicationDbContext applicationDbContext
    ) : ControllerBase
    {

        [HttpGet("{instructorId}/Courses", Name = "Get All Instructor courses")]
        public async Task<IActionResult> Get(Guid instructorId, CancellationToken cancellationToken)
        {
            //var sql = applicationDbContext.Instructors
            //    .Include(x => x.Courses)
            //    .Where(x => x.Id == instructorId)
            //    .ToQueryString();

            var instructor = await applicationDbContext.Instructors
                .Include(x => x.Courses)
                .FirstAsync(x => x.Id == instructorId, cancellationToken);
            return Ok(instructor);
        }
    }
}
