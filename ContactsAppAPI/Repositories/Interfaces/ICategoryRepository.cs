using ContactsAppAPI.Abstracts;
using ContactsAppAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactsAppAPI.Repositories.Interfaces
{
    public interface ICategoryRepository : IRepositoryBase<Category>
    {
        Task<IEnumerable<Category>> GetAllCategorysAsync();
        Task<Category> GetCategoryByIdAsync(long id);
        Category GetCategoryById(long id);
        void CreateCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
    }
}
