using ASPNetDocker.Models;
using System.Threading.Tasks;

namespace ASPNetDocker.Interfaces
{
    public interface ICategoryManager
    {
        Task<Category> AddCategory(Category category);
    }
}