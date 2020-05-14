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
        [Route("GetById")]
        public async Task<IActionResult> GetById(string id)
        {
            var data = await jsonManager.GetJsonDataById(id);

            return Ok(data);
        }
    }
}