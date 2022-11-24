using ContactsAppAPI.Services.Interfaces;
using ContactsAppAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactsAppAPI.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        [Route("")]
        public async Task<List<Category>> Get()
        {
            var categories = await categoryService.GetAllAsync();
            return categories;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<Category> GetByIdAsync(long id)
        {
            var category = await categoryService.GetByIdAsync(id);
            return category;
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddCategory([FromBody] Category category)
        {
            categoryService.Create(category);

            return Ok();
        }

        [HttpPost]
        [Route("update")]
        public IActionResult UpdateCategory([FromBody] Category category)
        {
            categoryService.Update(category);

            return Ok();
        }

    }
}
