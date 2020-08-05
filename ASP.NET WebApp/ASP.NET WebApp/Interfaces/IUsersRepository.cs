using System.Threading.Tasks;
using ASPNetDocker.Models;

namespace ASPNetDocker.Interfaces
{
    public interface IUsersRepository
    {
        Task<User> GetByEmail(string id);
    }
}