using Matrix1141EF.Data.Entity;
using Matrix1141EF.Model.DTO;
using System.Threading.Tasks;

namespace Matrix1141EF.Repository.Interface
{
    public interface ICategoryRepostory
    {
        Task Create(Category category);
        Task<int> Submit();
        Task<Category> GetCategory(int id);
        void UpdateCategory(Category category);
        void Delete(Category category);
    }
}
