using System;
using System.Threading.Tasks;

namespace ASPNetDocker.Interfaces
{
    public interface IBaseDbContext
    {
        ValueTask<T> GetByIdAsync<T>(Guid id) where T : class;
    }
}