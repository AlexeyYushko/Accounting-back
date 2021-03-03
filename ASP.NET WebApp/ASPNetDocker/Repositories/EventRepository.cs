using ASPNetDocker.DataAccess.Models;
using ASPNetDocker.DataAccess.Repositories;
using ASPNetDocker.Interfaces;
using ASPNetDocker.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace ASPNetDocker.Repositories
{
    public class EventRepository : BaseRepository, IEventRepository
    {
        private readonly string connectionString;
        private readonly ISqlScriptReader scriptReader;
        protected override int DefaultTimeoutSeconds => 60;

        public EventRepository(IConfiguration conf, ISqlScriptReader scriptReader): base(conf)
        {
            connectionString = conf.GetConnectionString("Default");
            this.scriptReader = scriptReader;
        }

        public async Task<Event> AddEvent(Event ev)
        {
            var queryObject = new QueryObject(scriptReader.Get(this, "Scripts.AddEvent.sql"), new { ev.Amount, ev.CategoryId, ev.Date, ev.Description, ev.Type });

            var newId = await FirstOrDefaultAsync<Guid>(connectionString, queryObject);

            ev.Id = newId;

            return ev;
        }
    }
}
