using System;
using System.Threading.Tasks;

namespace DockerForWeb.Interfaces
{
    public interface IJsonManager
    {
        Task<string> GetJsonDataById(string id);
    }
}