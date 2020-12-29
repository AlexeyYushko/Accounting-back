using ASPNetDocker.Interfaces;
using ASPNetDocker.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASPNetDocker.Managers
{
    public class CurrencyManager : ICurrencyManager
    {
        private readonly ICurrencyRepository currencyRepository;

        public CurrencyManager(ICurrencyRepository currencyRepository)
        {
            this.currencyRepository = currencyRepository;
        }

        public async Task<IEnumerable<ExchangeRate>> GetExchangeRates(string baseCurrencyName)
        {
            return await currencyRepository.GetExchangeRates(baseCurrencyName);
        }
    }
}