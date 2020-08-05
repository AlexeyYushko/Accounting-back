using System.Threading.Tasks;

namespace ASPNetDocker.Interfaces
{
    public interface IJsonManager
    {
        Task<string> GetJsonDataById(string id);
    }
}