using edu.aramco.aspnet.api.Models.Requests;
using edu.aramco.aspnet.domainEntities.Context;
using edu.aramco.aspnet.domainEntities.Entities;
using edu.aramco.aspnet.services.IServices;
using edu.aramco.aspnet.services.Services;
using edu.aramco.aspnet.services.Services.SMSServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace edu.aramco.aspnet.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class UsersController(
        ApplicationDbContext applicationDbContext,
        IServiceProvider serviceProvider,
        IEnumerable<ISMSService> all,
        IConfiguration configuration
    ) : ControllerBase
    {

        [HttpPost("authenticate")]
        [AllowAnonymous]

        public async Task<IActionResult> AuthenticateUser(UserAuthenticationRequest request)
        {
            if (request.UserName != "aspnet" && request.Password != "123456")
            {
                return Unauthorized();
            }

            var jwt = configuration.GetSection("Jwt");
            var issuer = jwt["Issuer"]!;
            var audience = jwt["Audience"]!;
            var key = jwt["Key"]!;
            var minutes = int.Parse(jwt["AccessTokenMinutes"] ?? "15");

            var claims = new List<Claim>
            {
            };

            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var creds = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                claims: claims,
                notBefore: DateTime.UtcNow,
                expires: DateTime.UtcNow.AddMinutes(minutes),
                signingCredentials: creds
            );

            var tokenValue = new JwtSecurityTokenHandler().WriteToken(token);

            return Ok(tokenValue);
        }

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
        public async Task<ActionResult> Auth(
            string phoneNumber,
            string serviceProviderKey,
            CancellationToken cancellationToken = default
        )
        {
            // First way
            //var smsService = smsServices.Single(s => s.GetType().Name.StartsWith(serviceProvider, StringComparison.OrdinalIgnoreCase));

            // second way -- strategy pattern
            //ISMSService? smsService;
            //if (serviceProvider     == "Mobily")
            //{
            //    smsService = smsServices.Single(s => s.GetType() == typeof(MobilySMSService));
            //}
            //else if (serviceProvider == "STC")
            //{

            //    smsService = smsServices.Single(s => s.GetType() == typeof(STCSMSService));
            //}
            //else if (serviceProvider == "Zain")
            //{
            //    smsService = smsServices.Single(s => s.GetType() == typeof(ZainSMSService));
            //}
            //else
            //{
            //    throw new Exception("Invalid service provider");
            //}

            // third way
            var targetService = all.First(x => x.Key == serviceProviderKey);

            // the keyed style
            var smsService = serviceProvider.GetRequiredKeyedService<ISMSService>(
                serviceProviderKey
            );

            await smsService.Send(
                phoneNumber,
                "Your authentication code is 123456",
                cancellationToken
            );

            // another access to the database
            // a third access to the database
            // a fourth access to the database

            await applicationDbContext.SaveChangesAsync(cancellationToken);

            return NoContent();
        }

        [HttpPost(Name = "Add New User")]
        public async Task<ActionResult> AddNewUser(
            CreateUserRequestModel request,
            CancellationToken cancellationToken = default
        )
        {
            await applicationDbContext.Students.AddAsync(
                new Student
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
                    Telephone = "1234567890",
                    UpdatedAt = DateTime.UtcNow,
                },
                cancellationToken
            );

            await applicationDbContext.SaveChangesAsync(cancellationToken);
            await applicationDbContext.SaveChangesAsync(cancellationToken);

            return NoContent();
        }
    }
}
