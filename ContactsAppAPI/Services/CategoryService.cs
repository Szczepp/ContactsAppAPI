using ContactsAppAPI.Models;
using ContactsAppAPI.Repositories.Interfaces;
using ContactsAppAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ContactsAppAPI.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repo;

        public CategoryService(ICategoryRepository repo)
        {
            _repo = repo;
        }

        public void Create(Category entity)
        {
            _repo.CreateCategory(entity);
        }

        public async void Delete(long entityId)
        {
            var category = await _repo.GetCategoryByIdAsync(entityId);
            _repo.DeleteCategory(category);
        }

        public async Task<List<Category>> GetAllAsync()
        {
            var categories = await _repo.GetAllCategorysAsync();
            return categories.ToList();
        }

        public IEnumerable<Category> GetByCondition(Expression<Func<Category, bool>> expression)
        {
            var categories = _repo.GetByCondition(expression).ToList();
            return categories;
        }

        public async Task<Category> GetByIdAsync(long entityId)
        {
            return await GetByIdAsync(entityId);
        }

        public void Update(Category entity)
        {
            _repo.UpdateCategory(entity);
        }
    }
}
