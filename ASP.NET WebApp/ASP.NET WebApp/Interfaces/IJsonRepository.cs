using System.Threading.Tasks;

namespace ASPNetDocker.Interfaces
{
    public interface IJsonRepository
    {
        Task<string> GetJsonDataById(string id);
    }
}