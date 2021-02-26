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
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        private readonly string connectionString;
        private readonly ISqlScriptReader scriptReader;
        protected override int DefaultTimeoutSeconds => 60;

        public CategoryRepository(IConfiguration conf, ISqlScriptReader scriptReader): base(conf)
        {
            connectionString = conf.GetConnectionString("Default");
            this.scriptReader = scriptReader;
        }

        public async Task<Category> AddCategory(Category category)
        {
            var queryObject = new QueryObject(scriptReader.Get(this, "Scripts.AddCategory.sql"), new { category.Name, category.Capacity });

            var newId = await FirstOrDefaultAsync<Guid>(connectionString, queryObject);

            category.Id = newId;

            return category;
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            var queryObject = new QueryObject(scriptReader.Get(this, "Scripts.GetAllCategories.sql"));

            return await QueryAsync<Category>(connectionString, queryObject);
        }
    }
}
