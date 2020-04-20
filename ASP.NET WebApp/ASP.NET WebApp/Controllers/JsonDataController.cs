using System.Threading.Tasks;
using DockerForWeb.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DockerForWeb.Controllers
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
        public async Task<IActionResult> Get()
        {
            var data = await jsonManager.GetJsonDataById("fac11927-bb36-4170-8b55-593cfee62089");

            return Ok(data);
        }
    }
}