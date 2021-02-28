using System;
using System.Collections.Generic;
using ASPNetDocker.Models;
using System.Threading.Tasks;

namespace ASPNetDocker.Interfaces
{
    public interface ICategoryManager
    {
        Task<Category> AddCategory(Category category);
        Task<IEnumerable<Category>> GetAllCategories();
        Task<Category> UpdateCategory(Guid id, Category category);
    }
}