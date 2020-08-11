using ASPNetDocker.Interfaces;
using ASPNetDocker.Models;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using ASPNetDocker.DataAccess.Repositories;
using ASPNetDocker.DataAccess.Models;

namespace ASPNetDocker.Repositories
{
    public class UsersRepository: BaseRepository, IUsersRepository
    {
        private string connectionString;
        private readonly ISqlScriptReader scriptReader;
        protected override int DefaultTimeoutSeconds => 60;

        public UsersRepository(IConfiguration conf, ISqlScriptReader scriptReader): base(conf)
        {
            connectionString = conf.GetConnectionString("Default");
            this.scriptReader = scriptReader;
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            var queryObject = new QueryObject(scriptReader.Get(this, "Scripts.GetUserByEmail.sql"), new { email = email });

            var u = await FirstOrDefaultAsync<User>(connectionString, queryObject);

            return u;
        }
    }
}
