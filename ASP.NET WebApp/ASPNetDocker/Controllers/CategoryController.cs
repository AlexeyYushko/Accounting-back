using System;
using System.Threading.Tasks;
using ASPNetDocker.Interfaces;
using ASPNetDocker.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetDocker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryManager categoryManager;

        public CategoryController(ICategoryManager categoryManager)
        {
            this.categoryManager = categoryManager;
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Add(Category category)
        {
            return Ok(await categoryManager.AddCategory(category));
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await categoryManager.GetAllCategories());
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody]Category category)
        {
            return Ok(await categoryManager.UpdateCategory(id, category));
        }
    }
}
