using System;
using DockerForWeb.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using DockerForWeb.Models;

namespace DockerForWeb.Context
{
    public class BaseDbContext: DbContext, IBaseDbContext
    {
        public DbSet<JsonData> JsonData { get; set; }
        public BaseDbContext(DbContextOptions options) : base(options)
        {
        }

        public ValueTask<T> GetByIdAsync<T>(string id) where T: class
        {
            return FindAsync<T>(Guid.Parse(id));
        }
    }
}
