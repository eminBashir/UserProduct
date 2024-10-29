using Matrix1141EF.Model.DTO;
using Matrix1141EF.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Matrix1141EF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductCreateDTO model)
        {
            await _productService.Create(model);
            return Ok(model);
        }
        [HttpGet]
        public async Task<IActionResult> GetProduct(int id)
        {
            var result = await _productService.GetProduct(id);
            return Ok(result);
        }
        [HttpPut]
        public void UpdatePro(ProductUpdateDTO model,int id)
        {
            _productService.UpdatePro(model,id);
        }
        [HttpDelete]
        public void DeletePro(DeleteProductDTO model,int id)
        {
            _productService.DeletePro(model,id);
            
        }


    }
}
