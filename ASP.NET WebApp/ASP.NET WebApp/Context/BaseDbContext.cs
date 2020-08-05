using System;
using System.Threading.Tasks;
using ASPNetDocker.Interfaces;
using ASPNetDocker.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNetDocker.Context
{
    public class BaseDbContext : DbContext, IBaseDbContext
    {
        public DbSet<JsonData> JsonData { get; set; }
        public DbSet<User> Users { get; set; }

        public BaseDbContext(DbContextOptions options) : base(options)
        {
        }

        public ValueTask<T> GetByIdAsync<T>(Guid id) where T : class
            => FindAsync<T>(id);

    }
}
