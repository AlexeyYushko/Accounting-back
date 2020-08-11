using System.Threading.Tasks;
using ASPNetDocker.DataAccess.Interfaces;
using ASPNetDocker.Models;

namespace ASPNetDocker.Interfaces
{
    public interface IUsersRepository: IBaseRepository
    {
        Task<User> GetByEmailAsync(string id);
    }
}