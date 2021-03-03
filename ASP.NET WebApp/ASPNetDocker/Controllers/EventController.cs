using ASPNetDocker.Interfaces;
using ASPNetDocker.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ASPNetDocker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly IEventManager eventManager;

        public EventController(IEventManager eventManager)
        {
            this.eventManager = eventManager;
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Add(Event ev)
        {
            return Ok(await eventManager.AddEvent(ev));
        }
    }
}
