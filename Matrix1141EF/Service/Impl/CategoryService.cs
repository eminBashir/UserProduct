using AutoMapper;
using Matrix1141EF.Data.Entity;
using Matrix1141EF.Model.DTO;
using Matrix1141EF.Repository.Interface;
using Matrix1141EF.Service.Interface;
using System.Threading.Tasks;

namespace Matrix1141EF.Service.Impl
{
    public class CategoryService : ICategoryService
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepostory _categoryRepostory;
        public CategoryService(IMapper mapper, ICategoryRepostory categoryRepostory)
        {
            _categoryRepostory = categoryRepostory;
            _mapper = mapper;
        }
        public async Task Create(CategoryCreateDTO model)
        {
            var categoryEntity = _mapper.Map<Category>(model);
            await _categoryRepostory.Create(categoryEntity);
            _ = await _categoryRepostory.Submit();
        }

        public void Delete(CategoryDeleteDTO model, int id)
        {
            var deleteEntity = _mapper.Map<Category>(model);
            _categoryRepostory.Delete(deleteEntity);
            _ = _categoryRepostory.Submit();
        }

        public async Task<GetCategoryDTO> GetCategory(int id)
        {
            var categoryEntity = await _categoryRepostory.GetCategory(id);
            var categoryDTO = _mapper.Map<GetCategoryDTO>(categoryEntity);
            return categoryDTO;

        }



        public void UpdateCategory(CategoryUpdateDTO model, int id)
        {
            var exist = _categoryRepostory.GetCategory(id);
            var categoryEntity = _mapper.Map<Category>(model);
            if (exist != null)
            {
                _categoryRepostory.UpdateCategory(categoryEntity);
               // _ = _categoryRepostory.Submit();
            }
            else
            {
                throw new System.Exception();
            }


        }
    }
}
