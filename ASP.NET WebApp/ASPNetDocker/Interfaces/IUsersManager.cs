using System.Threading.Tasks;
using ASPNetDocker.Models;

namespace ASPNetDocker.Interfaces
{
    public interface IUsersManager
    {
        Task<User> GetByEmail(string email);
    }
}