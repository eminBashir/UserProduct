using Matrix1141EF.Data.Entity;
using System.Threading.Tasks;

namespace Matrix1141EF.Repository.Interface
{
    public interface IProductRepostory
    {
        Task Create(Product product);
        Task<int> Submit();
        Task<Product> GetProduct(int id);
        void UpdatePro(Product product);
        void DeletePro(Product product);

    }
}
