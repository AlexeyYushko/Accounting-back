using System;
using ASPNetDocker.Interfaces;
using ASPNetDocker.Models;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using ASPNetDocker.DataAccess.Repositories;
using ASPNetDocker.DataAccess.Models;

namespace ASPNetDocker.Repositories
{
    public class BillRepository : BaseRepository, IBillRepository
    {
        private readonly string connectionString;
        private readonly ISqlScriptReader scriptReader;
        protected override int DefaultTimeoutSeconds => 60;

        public BillRepository(IConfiguration conf, ISqlScriptReader scriptReader): base(conf)
        {
            connectionString = conf.GetConnectionString("Default");
            this.scriptReader = scriptReader;
        }

        public async Task<Bill> GetByUserId(Guid userId)
        {
            var queryObject = new QueryObject(scriptReader.Get(this, "Scripts.GetBillByUserId.sql"), new { userId = userId });

            var bill = await FirstOrDefaultAsync<Bill>(connectionString, queryObject);

            return bill;
        }
    }
}
