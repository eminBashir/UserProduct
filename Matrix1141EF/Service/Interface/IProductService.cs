using Matrix1141EF.Model.DTO;
using System.Threading.Tasks;

namespace Matrix1141EF.Service.Interface
{
    public interface IProductService
    {
        Task Create(ProductCreateDTO model);
        Task<GetProductDTO> GetProduct(int id);
        void UpdatePro(ProductUpdateDTO model,int id);
        void DeletePro(DeleteProductDTO model,int id);
    }
}
