using AutoMapper;
using Matrix1141EF.Data.Entity;
using Matrix1141EF.Model.DTO;
using Matrix1141EF.Repository.Interface;
using Matrix1141EF.Service.Interface;
using System.Threading.Tasks;

namespace Matrix1141EF.Service.Impl
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepostory _productRepostory;


        public ProductService(IMapper mapper, IProductRepostory productRepostory)
        {
            _mapper = mapper;
            _productRepostory = productRepostory;
        }
        public async Task Create(ProductCreateDTO model)
        {
            var productEntity = _mapper.Map<Product>(model);
            await _productRepostory.Create(productEntity);
            _ = await _productRepostory.Submit();
        }

        public void DeletePro(DeleteProductDTO model, int id)
        {
            var deleteEntity = _mapper.Map<Product>(model);
            _productRepostory.DeletePro(deleteEntity);
            _ = _productRepostory.Submit();
        }

        public async Task<GetProductDTO> GetProduct(int id)
        {
            var productEntity = await _productRepostory.GetProduct(id);
            var productDto = _mapper.Map<GetProductDTO>(productEntity);
            return productDto;
        }

        public void UpdatePro(ProductUpdateDTO model, int id)
        {
            var exist = _productRepostory.GetProduct(id);
            var productEntity = _mapper.Map<Product>(model);
            if (exist != null)
            {
                _productRepostory.UpdatePro(productEntity);
                _ = _productRepostory.Submit();
            }
            else
            {
                throw new System.Exception();
            }
        }
    }
}
