using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASPNetDocker.DataAccess.Interfaces;
using ASPNetDocker.Models;

namespace ASPNetDocker.Interfaces
{
    public interface ICurrencyRepository : IBaseRepository
    {
        Task<IEnumerable<ExchangeRate>> GetExchangeRates(Guid baseCurrencyId);
    }
}