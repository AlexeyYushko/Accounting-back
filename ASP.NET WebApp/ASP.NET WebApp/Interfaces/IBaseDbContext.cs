using System.Threading.Tasks;

namespace DockerForWeb.Interfaces
{
    public interface IBaseDbContext
    {
        ValueTask<T> GetByIdAsync<T>(string Id) where T : class;
    }
}