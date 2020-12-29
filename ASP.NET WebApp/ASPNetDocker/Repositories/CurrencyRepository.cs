using ASPNetDocker.DataAccess.Models;
using ASPNetDocker.DataAccess.Repositories;
using ASPNetDocker.Interfaces;
using ASPNetDocker.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASPNetDocker.Repositories
{
    public class CurrencyRepository : BaseRepository, ICurrencyRepository
    {
        private readonly string connectionString;
        private readonly ISqlScriptReader scriptReader;
        protected override int DefaultTimeoutSeconds => 60;

        public CurrencyRepository(IConfiguration conf, ISqlScriptReader scriptReader): base(conf)
        {
            connectionString = conf.GetConnectionString("Default");
            this.scriptReader = scriptReader;
        }

        public async Task<IEnumerable<ExchangeRate>> GetExchangeRates(string baseCurrencyName)
        {
            var queryObject = new QueryObject(scriptReader.Get(this, "Scripts.GetExchangeRatesByCurrencyName.sql"), new { baseCurrencyName = baseCurrencyName });

            return await QueryAsync<ExchangeRate>(connectionString, queryObject);
        }
    }
}
