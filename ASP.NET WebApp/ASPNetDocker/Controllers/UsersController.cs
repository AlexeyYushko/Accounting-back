using System;
using System.Threading.Tasks;
using ASPNetDocker.Interfaces;
using ASPNetDocker.Models;
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
        public async Task<IActionResult> Get([FromQuery]string email, [FromQuery]Guid id)
        {
            var user = await usersManager.GetByEmail(email);

            return Ok(user);
        }


        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Add([FromBody] User user)
        {
            return Ok(await usersManager.AddUser(user));
        }
    }
}
