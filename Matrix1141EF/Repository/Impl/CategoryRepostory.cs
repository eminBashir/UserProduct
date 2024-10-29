using Matrix1141EF.Data;
using Matrix1141EF.Data.Entity;
using Matrix1141EF.Repository.Interface;
using System.Threading.Tasks;

namespace Matrix1141EF.Repository.Impl
{
    public class CategoryRepostory : ICategoryRepostory
    {
        private readonly AppDbContext _context;
        public CategoryRepostory(AppDbContext context)
        {
            _context = context;
        }

        

        public async Task Create(Category category)
        {
            await _context.Categories.AddAsync(category);
            
        }

        public void Delete(Category category)
        {
             _context.Categories.Remove(category);
            
        }

        public async Task<Category> GetCategory(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public async Task<int> Submit()
        {
            return await _context.SaveChangesAsync();
        }

        public  void UpdateCategory(Category category)
        { 
            _context.Categories.Update(category);
           
        }
    }
}
