using Matrix1141EF.Data;
using Matrix1141EF.Data.Entity;
using Matrix1141EF.Repository.Interface;
using System.Threading.Tasks;

namespace Matrix1141EF.Repository.Impl
{
    public class ProductRepostory : IProductRepostory
    {
        private readonly AppDbContext _context;
        public ProductRepostory(AppDbContext context)
        {
            _context = context;
        }
        public async Task Create(Product product)
        {
            await _context.Products.AddAsync(product);
            
        }

        public void DeletePro(Product product)
        {
             _context.Products.Remove(product);
        }

        public async Task<Product> GetProduct(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<int> Submit()
        {
            return await _context.SaveChangesAsync();
        }

        public void UpdatePro(Product product)
        {
            _context.Products.Update(product);
        }
    }
}
