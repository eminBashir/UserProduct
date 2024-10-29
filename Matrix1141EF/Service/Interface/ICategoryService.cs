using Matrix1141EF.Model.DTO;
using System.Threading.Tasks;

namespace Matrix1141EF.Service.Interface
{
    public interface ICategoryService
    {
        Task Create(CategoryCreateDTO model);
        Task<GetCategoryDTO> GetCategory(int id);
        void UpdateCategory(CategoryUpdateDTO model,int id);
        void Delete(CategoryDeleteDTO model,int id);
    }
}
