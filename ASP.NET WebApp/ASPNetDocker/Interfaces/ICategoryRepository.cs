using ASPNetDocker.DataAccess.Interfaces;
using ASPNetDocker.Models;
using System.Threading.Tasks;

namespace ASPNetDocker.Interfaces
{
    public interface ICategoryRepository : IBaseRepository
    {
        Task<Category> AddCategory(Category category);
    }
}