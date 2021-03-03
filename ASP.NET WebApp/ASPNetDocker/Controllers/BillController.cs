using ASPNetDocker.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using ASPNetDocker.Models;

namespace ASPNetDocker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private readonly IBillManager billManager;

        public BillController(IBillManager billManager)
        {
            this.billManager = billManager;
        }

        [HttpGet]
        [Route("GetByUserId")]
        public async Task<IActionResult> GetByUserId(Guid userId)
        {
            var bill = await billManager.GetByUserId(userId);

            return Ok(bill);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] Bill bill)
        {
            return Ok(await billManager.UpdateBill(id, bill));
        }
    }
}
