using edu.aramco.aspnet.api.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace edu.aramco.aspnet.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        /// <summary>
        /// Get the list of users
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "Get List Of Users")]
        public IEnumerable<string> Get(int top, CancellationToken cancellationToken = default)
        {
            return new string[] { "Akmal", "Aldahdooh" };
        }


        [HttpPost(Name = "Add New User")]
        public ActionResult AddNewUser(CreateUserRequestModel request, CancellationToken cancellationToken = default)
        {
            return NoContent();
        }
    }
}
