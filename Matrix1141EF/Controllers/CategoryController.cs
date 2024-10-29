using Matrix1141EF.Model.DTO;
using Matrix1141EF.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Matrix1141EF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryservice)
        {
            _categoryService = categoryservice;
        }
        [HttpPost]
        public async Task<IActionResult> Create(CategoryCreateDTO model)
        {
            await _categoryService.Create(model);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetCategory(int id)
        {
            var result = await _categoryService.GetCategory(id);
            return Ok(result);
        }
        [HttpPut]
        public void UpdateCategory(CategoryUpdateDTO model, int id)
        {
            _categoryService.UpdateCategory(model, id);

        }
        [HttpDelete]
        public void Delete(CategoryDeleteDTO model, int id)
        {
            _categoryService.Delete(model, id);

        }
    }
}
