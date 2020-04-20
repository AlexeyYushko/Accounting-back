using System.Threading.Tasks;
using DockerForWeb.Interfaces;

namespace DockerForWeb.Managers
{
    public class JsonManager: IJsonManager
    {
        private readonly IJsonRepository jsonRepository;

        public JsonManager(IJsonRepository jsonRepository)
        {
            this.jsonRepository = jsonRepository;
        }

        public async Task<string> GetJsonDataById(string id)
        {
            return await jsonRepository.GetJsonDataById(id);
        }
    }
}