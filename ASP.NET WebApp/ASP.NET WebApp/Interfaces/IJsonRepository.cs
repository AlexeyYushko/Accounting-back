using System.Threading.Tasks;

namespace DockerForWeb.Interfaces
{
    public interface IJsonRepository
    {
        Task<string> GetJsonDataById(string id);
    }
}