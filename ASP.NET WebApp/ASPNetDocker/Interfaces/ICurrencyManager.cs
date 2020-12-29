using ASPNetDocker.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASPNetDocker.Interfaces
{
    public interface ICurrencyManager
    {
        Task<IEnumerable<ExchangeRate>> GetExchangeRates(string baseCurrencyName);
    }
}