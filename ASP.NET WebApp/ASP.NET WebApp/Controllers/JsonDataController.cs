using System.Threading.Tasks;
using ASPNetDocker.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetDocker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JsonDataController : ControllerBase
    {
        private readonly IJsonManager jsonManager;

        public JsonDataController(IJsonManager jsonManager)
        {
            this.jsonManager = jsonManager;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> GetById(string id)
        {
            var data = await jsonManager.GetJsonDataById(id);

            return Ok(data);
        }
    }
}