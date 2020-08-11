using System.Threading.Tasks;
using ASPNetDocker.DataAccess.Models;

namespace ASPNetDocker.DataAccess.Interfaces
{
    public interface IBaseRepository
    {
        Task<T> FirstOrDefaultAsync<T>(string connectionString, QueryObject queryObject, int? timeoutSeconds);
    }
}