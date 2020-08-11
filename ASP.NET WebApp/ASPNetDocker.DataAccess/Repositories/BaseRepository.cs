using System.Data.SqlClient;
using System.Threading.Tasks;
using ASPNetDocker.DataAccess.Interfaces;
using ASPNetDocker.DataAccess.Models;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace ASPNetDocker.DataAccess.Repositories
{
    public class BaseRepository: IBaseRepository
    {
        protected virtual int DefaultTimeoutSeconds { get; }

        public BaseRepository(IConfiguration conf)
        {
            DefaultTimeoutSeconds = int.Parse(conf["DefaultSqlRequestTimeoutSeconds"]);
        }

        public async Task<T> FirstOrDefaultAsync<T>(string connectionString, QueryObject queryObject, int? timeoutSeconds = null)
        {
            timeoutSeconds ??= DefaultTimeoutSeconds;

            await using var conn = new SqlConnection(connectionString);

            T result = await conn.QueryFirstOrDefaultAsync<T>(queryObject.Sql, queryObject.QueryParameters, commandTimeout: timeoutSeconds);

            return result;
        }
    }
}
