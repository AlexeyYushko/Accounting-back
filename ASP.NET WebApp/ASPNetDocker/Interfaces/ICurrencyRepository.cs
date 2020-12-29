using ASPNetDocker.DataAccess.Interfaces;
using ASPNetDocker.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASPNetDocker.Interfaces
{
    public interface ICurrencyRepository : IBaseRepository
    {
        Task<IEnumerable<ExchangeRate>> GetExchangeRates(string baseCurrencyName);
    }
}