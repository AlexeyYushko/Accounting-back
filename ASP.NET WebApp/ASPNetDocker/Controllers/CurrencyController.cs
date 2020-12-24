using ASPNetDocker.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ASPNetDocker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly ICurrencyManager currencyManager;

        public CurrencyController(ICurrencyManager currencyManager)
        {
            this.currencyManager = currencyManager;
        }

        [HttpGet]
        [Route("GetExchangeRates")]
        public async Task<IActionResult> GetExchangeRates(Guid baseCurrencyId)
        {
            var rates = await currencyManager.GetExchangeRates(baseCurrencyId);

            return Ok(rates);
        }
    }
}
