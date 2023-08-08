using DesignPatterns.Decorator.Models;
using Microsoft.EntityFrameworkCore;

namespace DesignPatterns.Decorator.Repositories
{
    public class ProductRepository : IProductRepository
    {
        readonly DbSet<Product>  _product;
        readonly AppDbContext _appDbContext;

        public ProductRepository(AppDbContext appDbContext)
        {
            _product = appDbContext.Set<Product>();
            _appDbContext = appDbContext;
        }

        public async Task<Product> CreateAsync(Product product)
        {
            await _product.AddAsync(product);
            await _appDbContext.SaveChangesAsync();
            return product;
        }

        public async Task DeleteAsync(int productId)
        {
            _product.Remove(await GetByIdAsync(productId));
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _product.ToListAsync();
        }

        public async Task<List<Product>> GetAllAsync(string userId)
        {
            return await _product.Where(x=>x.UserId==userId).ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int productId)
        {
            return await _product.FirstOrDefaultAsync(x => x.Id == productId) ;
        }

        public async Task UpdateAsync(Product product)
        {
            _product.Update(product);
            await _appDbContext.SaveChangesAsync();
              
        }
    }
}
