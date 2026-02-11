using edu.aramco.aspnet.api.Models.Requests;
using edu.aramco.aspnet.domainEntities.Context;
using edu.aramco.aspnet.domainEntities.Entities;
using edu.aramco.aspnet.services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace edu.aramco.aspnet.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController(ApplicationDbContext applicationDbContext, ISMSService smsService) : ControllerBase
    {
        /// <summary>
        /// Get the list of users
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "Get List Of Users")]
        public IEnumerable<string> Get(int top, CancellationToken cancellationToken = default)
        {
            return new string[] { "Akmal", "Aldahdooh" };
        }

        [HttpPost("auth", Name = "Authenticate User request")]
        public async Task<ActionResult> Auth(string phoneNumber, CancellationToken cancellationToken = default)
        {
            await smsService.Send(phoneNumber, "Your authentication code is 123456", cancellationToken);
            // another access to the database 
            // a third access to the database
            // a fourth access to the database

            await applicationDbContext.SaveChangesAsync(cancellationToken);

            return NoContent();
        }

        [HttpPost(Name = "Add New User")]
        public async Task<ActionResult> AddNewUser(CreateUserRequestModel request, CancellationToken cancellationToken = default)
        {
            await applicationDbContext.Students.AddAsync(new Student
            {
                Address = "Khobar",
                ApplicationStatus = "Active",
                CreatedAt = DateTime.UtcNow,
                DOB = new DateTime(1990, 1, 1),
                EntranceDate = new DateTime(2020, 1, 1),
                FirstName = request.FirstName,
                LastName = request.LastName,
                Gender = request.Gender.ToCharArray()[0],
                Password = "Password",
                Level = "Level",
                EmailAddress = "akmal@domain.com",
                GraduationDate = new DateTime(2024, 1, 1),
                Justification = "Justification",
                Major = "Computer Science",
                Telephone = "1234567890",
                UpdatedAt = DateTime.UtcNow
            }, cancellationToken);

            await applicationDbContext.SaveChangesAsync(cancellationToken);
            await applicationDbContext.SaveChangesAsync(cancellationToken);

            return NoContent();
        }
    }
}
