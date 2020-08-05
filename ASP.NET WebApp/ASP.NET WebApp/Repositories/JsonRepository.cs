using System;
using System.Threading.Tasks;
using ASPNetDocker.Interfaces;
using ASPNetDocker.Models;

namespace ASPNetDocker.Repositories
{
    public class JsonRepository: IJsonRepository
    {
        private readonly IBaseDbContext dbContext;

        public JsonRepository(IBaseDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<string> GetJsonDataById(string id)
        {
            var jsonData = await dbContext.GetByIdAsync<JsonData>(Guid.Parse(id));

            return jsonData.Json;
        }
    }
}
