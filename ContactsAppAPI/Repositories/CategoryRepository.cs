using ContactsAppAPI.Abstracts;
using ContactsAppAPI.Data;
using ContactsAppAPI.Models;
using ContactsAppAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ContactsAppAPI.Repositories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public void CreateCategory(Category category)
        {
            Create(category);
        }

        public void DeleteCategory(Category category)
        {
            Delete(category);
        }

        public async Task<IEnumerable<Category>> GetAllCategorysAsync()
        {
            return await GetAll().ToListAsync();
        }

        public async Task<Category> GetCategoryByIdAsync(long id)
        {
            return await GetCategoryByIdAsync(id);
        }
        public Category GetCategoryById(long id)
        {
            return _db.Categories.Find(id);
        }

        public void UpdateCategory(Category category)
        {
            Update(category);
        }
    }
}
