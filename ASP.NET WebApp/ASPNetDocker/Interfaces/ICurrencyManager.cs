using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASPNetDocker.Models;

namespace ASPNetDocker.Interfaces
{
    public interface ICurrencyManager
    {
        Task<IEnumerable<ExchangeRate>> GetExchangeRates(Guid baseCurrencyId);
    }
}