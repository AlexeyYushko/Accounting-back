using ASPNetDocker.Interfaces;
using ASPNetDocker.Models;
using System.Threading.Tasks;
using Dapper;


namespace ASPNetDocker.Repositories
{
    public class UsersRepository: IUsersRepository
    {
        public async Task<User> GetByEmail(string email)
        {
            

        }

        
    }
}
