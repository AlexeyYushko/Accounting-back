using System.Threading.Tasks;
using ASPNetDocker.Interfaces;
using ASPNetDocker.Models;

namespace ASPNetDocker.Managers
{
    public class UsersManager: IUsersManager
    {
        private readonly IUsersRepository usersRepository;

        public UsersManager(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        public async Task<User> GetByEmail(string email)
        {
            return await usersRepository.GetByEmail(email);
        }

        public async Task<User> AddUser(User user)
        {
            return await usersRepository.AddUser(user);
        }
    }
}