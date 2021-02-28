using System;
using System.Collections.Generic;
using ASPNetDocker.DataAccess.Interfaces;
using ASPNetDocker.Models;
using System.Threading.Tasks;

namespace ASPNetDocker.Interfaces
{
    public interface ICategoryRepository : IBaseRepository
    {
        Task<Category> AddCategory(Category category);
        Task<Category> UpdateCategory(Guid id, Category category);

        Task<IEnumerable<Category>> GetAllCategories();
    }
}