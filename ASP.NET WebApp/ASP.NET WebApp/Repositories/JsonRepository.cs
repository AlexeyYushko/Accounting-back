using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DockerForWeb.Interfaces;
using DockerForWeb.Models;

namespace DockerForWeb.Repositories
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
            var jsonData = await dbContext.GetByIdAsync<JsonData>(id);

            return jsonData.Data;
        }
    }
}
