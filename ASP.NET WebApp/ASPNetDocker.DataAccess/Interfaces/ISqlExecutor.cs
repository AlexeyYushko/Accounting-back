using System.Threading.Tasks;
using ASPNetDocker.DataAccess.Models;

namespace ASPNetDocker.DataAccess.Interfaces
{
    public interface ISqlExecutor
    {
        Task<T> FirstOrDefaultAsync<T>(QueryObject queryObject);
    }
}