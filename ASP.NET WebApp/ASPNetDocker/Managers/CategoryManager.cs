using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASPNetDocker.Interfaces;
using ASPNetDocker.Models;

namespace ASPNetDocker.Managers
{
    public class CategoryManager : ICategoryManager
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public async Task<Category> AddCategory(Category category)
        {
            return await categoryRepository.AddCategory(category);
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await categoryRepository.GetAllCategories();
        }

        public async Task<Category> UpdateCategory(Guid id, Category category)
        {
            return await categoryRepository.UpdateCategory(id, category);
        }
    }
}