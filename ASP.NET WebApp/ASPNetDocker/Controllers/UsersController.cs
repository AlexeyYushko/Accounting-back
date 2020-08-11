using System.Threading.Tasks;
using ASPNetDocker.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetDocker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersManager usersManager;

        public UsersController(IUsersManager usersManager)
        {
            this.usersManager = usersManager;
        }

        [HttpGet]
        [Route("GetByEmail")]
        public async Task<IActionResult> GetByEmail(string email)
        {
            var user = await usersManager.GetByEmail(email);

            return Ok(user);
        }
    }
}
